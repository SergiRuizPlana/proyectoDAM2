package controllers;

import java.io.File;
import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

import javax.swing.JFileChooser;

import dao.UserDAO;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.geometry.Insets;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button; 
import javafx.scene.control.TableCell;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextField;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.AnchorPane; 
import javafx.scene.layout.HBox;
import javafx.scene.layout.VBox;
import javafx.stage.FileChooser;
import javafx.stage.Stage;
import javafx.util.Callback; 
import model.UserFx;
import test.Test;

public class TeacherController implements Initializable{


	@FXML
	private TextField fnameText,lnameText,nif,phone,adress;

	@FXML
	private Button openImg,showStudentBtn,returnBtn,createStudentBtn;

	@FXML
	private TableColumn<UserFx,String> fnameCol,lnameCol,nifCol,phoneCol,emailCol,addresCol,cityCol;



	@FXML
	private AnchorPane showStudentPane,showStudentsPane;


	@FXML
	private TableView<UserFx> studentsList;

	@FXML
	private TableColumn<UserFx,String> editCol;


	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		fnameCol.setCellValueFactory(new PropertyValueFactory<>("fname"));
		lnameCol.setCellValueFactory(new PropertyValueFactory<>("lname"));
		nifCol.setCellValueFactory(new PropertyValueFactory<>("nif"));
		phoneCol.setCellValueFactory(new PropertyValueFactory<>("phone"));
		emailCol.setCellValueFactory(new PropertyValueFactory<>("email"));
		addresCol.setCellValueFactory(new PropertyValueFactory<>("adress"));
		cityCol.setCellValueFactory(new PropertyValueFactory<>("city"));
		//add cell of button edit 
		Callback<TableColumn<UserFx, String>, TableCell<UserFx, String>> cellFoctory = (TableColumn<UserFx, String> param) -> {
			// make cell containing buttons
			final TableCell<UserFx, String> cell = new TableCell<UserFx, String>() {
				@Override
				public void updateItem(String item, boolean empty) {
					super.updateItem(item, empty);
					//that cell created only on non-empty rows
					if (empty) {
						setGraphic(null);
						setText(null);

					} else {

						Button deleteIcon = new Button("edit");
						Button editIcon = new Button("rm");

						deleteIcon.setStyle(
								" -fx-cursor: hand ;"
										+ "-glyph-size:28px;"
										+ "-fx-fill:#ff1744;"
								);
						editIcon.setStyle(
								" -fx-cursor: hand ;"
										+ "-glyph-size:28px;"
										+ "-fx-fill:#00E676;"
								);
						deleteIcon.setOnMouseClicked((MouseEvent event) -> {

						});
						editIcon.setOnMouseClicked((MouseEvent event) -> {
							showStudentPane.toFront();
							UserFx ufx =studentsList.getSelectionModel().getSelectedItem();
							fnameText.setText(ufx.getFname());
							lnameText.setText(ufx.getLname());
						});

						HBox managebtn = new HBox(editIcon, deleteIcon);
						managebtn.setStyle("-fx-alignment:center");
						HBox.setMargin(deleteIcon, new Insets(2, 2, 0, 3));
						HBox.setMargin(editIcon, new Insets(2, 3, 0, 2));

						setGraphic(managebtn);

						setText(null);

					}
				}

			};

			return cell;
		};

		editCol.setCellFactory(cellFoctory);
		 ExecutorService service = Executors.newFixedThreadPool(4);
		    service.submit(new Runnable() {
		        public void run() {
		            studentsList.setItems(UserDAO.getUsers());
		            service.shutdownNow();
		        }
		    });

	}

	
	

	public void showListPane(ActionEvent event) {
		showStudentsPane.toFront();
	}

	public void imgSelect(ActionEvent event) {
		FileChooser fx=new FileChooser();
		File selectedFile=fx.showOpenDialog(null);
	}

	


}
