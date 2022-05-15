package controllers;


import java.net.URL;
import java.util.ResourceBundle;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;


import dao.UserDAO;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.geometry.Insets;
import javafx.scene.control.Button;
import javafx.scene.control.CheckBox;
import javafx.scene.control.RadioButton;
import javafx.scene.control.TableCell;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextField;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.AnchorPane; 
import javafx.scene.layout.HBox;
import javafx.scene.text.Text;
import javafx.util.Callback;
import model.User; 
import utils.ControlUtils;

public class TeacherController implements Initializable{


	@FXML
	private TextField fnameText,lnameText,nifText,phoneText,adressText,zipText,emailText,cityText;

	@FXML
	private TextField fnameText2,lnameText2,nifText2,phoneText2,adressText2,zipText2,emailText2,cityText2, usernameText,psswdText;

	@FXML
	private Text userNameHide;
	@FXML
	private Button openImg,showStudentBtn,returnBtn,createStudentBtn,saveStudentBtn,cancelStudentBtn;

	@FXML
	private TableColumn<User,String> fnameCol,lnameCol,nifCol,phoneCol,emailCol,addresCol,cityCol;

	@FXML
	private AnchorPane showStudentPane,showStudentsPane,createPane;

	@FXML
	private TableView<User> studentsList;

	@FXML
	private TableColumn<User,String> editCol;
	
	@FXML
	private RadioButton studentRole,studentRole2,teacherRole,teacherRole2;


	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		fnameCol.setCellValueFactory(new PropertyValueFactory<>("fname"));
		lnameCol.setCellValueFactory(new PropertyValueFactory<>("lname"));
		nifCol.setCellValueFactory(new PropertyValueFactory<>("nif"));
		phoneCol.setCellValueFactory(new PropertyValueFactory<>("phone"));
		emailCol.setCellValueFactory(new PropertyValueFactory<>("email"));
		addresCol.setCellValueFactory(new PropertyValueFactory<>("adress"));
		cityCol.setCellValueFactory(new PropertyValueFactory<>("city"));


		Callback<TableColumn<User, String>, TableCell<User, String>> cellFoctory = (TableColumn<User, String> param) -> {

			final TableCell<User, String> cell = new TableCell<User, String>() {
				@Override
				public void updateItem(String item, boolean empty) {
					super.updateItem(item, empty);
					//that cell created only on non-empty rows
					if (empty) {
						setGraphic(null);
						setText(null);

					} else {

////						Image editIgm = new Image("src\\resources\\img\\edit.png");
//						ImageView view = new ImageView(editIgm);
////						Image deleteImg = new Image("src/resources/img/ltrash.png");
//						System.out.println(deleteImg.getUrl());
//						ImageView view2 = new ImageView(deleteImg);
//						view.setFitHeight(22);
//						view.setPreserveRatio(true);
//						view2.setFitHeight(22);
//						view2.setPreserveRatio(true);
						Button deleteIcon = new Button();
						Button editIcon = new Button();
//						
//						deleteIcon.setGraphic(view);
//						editIcon.setGraphic(view2);

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
							//							UserFx ufx = getTableRow().getItem();
							//					        UserDAO.
							//TODO

						});
						editIcon.setOnMouseClicked((MouseEvent event) -> {
							showStudentPane.toFront();
							User usr = getTableRow().getItem();
							fnameText.setText(usr.getFname());
							lnameText.setText(usr.getLname());
							nifText.setText(usr.getNif());
							emailText.setText(usr.getEmail());
							cityText.setText(usr.getCity());
							zipText.setText(usr.getZip());
							phoneText.setText(usr.getPhone());
							lnameText.setText(usr.getLname());
							userNameHide.setText(usr.getUserName());
							adressText.setText(usr.getAdress());
							if(usr.isStudent()) {
								studentRole.setSelected(true);
							}else {
								teacherRole.setSelected(true);
							}
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
				studentsList.getItems().addAll(UserDAO.getUsers());
				service.shutdownNow();
			}
		});

	}


	public void showListPane(ActionEvent event) {
		showStudentsPane.toFront();
	}

	public void imgSelect(ActionEvent event) {
		//		FileChooser fx=new FileChooser();
		//		File selectedFile=fx.showOpenDialog(null);
	}


	public void activeTextBoxes(ActionEvent event) {
		fnameText.setEditable(true);
		lnameText.setEditable(true);
		nifText.setEditable(true);
		emailText.setEditable(true);
		cityText.setEditable(true);
		zipText.setEditable(true);
		phoneText.setEditable(true);
		adressText.setEditable(true);
		saveStudentBtn.setVisible(true);
		cancelStudentBtn.setVisible(true);
	}

	public void saveStudent(ActionEvent event) { 
		String[] userInfo= {nifText.getText(), fnameText.getText(), lnameText.getText(), adressText.getText(), cityText.getText(),zipText.getText(), phoneText.getText(),emailText.getText(),studentRole.isSelected()?"STUDENT":"TEACHER"};
		System.out.println(UserDAO.updateUser(userInfo,userNameHide.getText()));
		TextField[] texts={nifText, fnameText, lnameText, adressText, cityText,zipText, phoneText,emailText};
		ControlUtils.resetTextBox(texts);
		showStudentsPane.toFront();	
	}

	public void createStudent(ActionEvent event) { 
		User student=new User(nifText2.getText(), fnameText2.getText(), lnameText2.getText(),usernameText.getText(), adressText2.getText(), cityText2.getText(),zipText2.getText(), phoneText2.getText(), psswdText.getText(),emailText2.getText(),studentRole2.isSelected()?"STUDENT":"TEACHER");
		System.out.println(UserDAO.insertUser(student));
		TextField[] texts={nifText2, fnameText2, lnameText2,usernameText, adressText2, cityText2,zipText2, phoneText2, psswdText,emailText2};
		ControlUtils.resetTextBox(texts);
		showStudentsPane.toFront();

	}

	public void createNewStudent() {
		createPane.toFront();
	}


	public void cancelStudentEdit(ActionEvent event) {
		showStudentsPane.toFront();
	}

}
