package controllers;


import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;

import dao.UserDAO;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.Pane;
import javafx.scene.layout.StackPane;
import javafx.stage.Stage;
import model.UserFx;

public class HomeController implements Initializable {
	
	private  Stage stage;
	private  Scene scene;
	private  Parent root;
	@FXML
	private BorderPane bp;

	@FXML
	private Button b1;

	@FXML
	private AnchorPane views;





	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		// TODO Auto-generated method stub
		try {
			UserDAO.openConnection();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		loadFxml(null);
		//		nifCol.setCellValueFactory(new PropertyValueFactory<>("Nif"));
		//		fnameCol.setCellValueFactory(new PropertyValueFactory<>("Fname"));
		//		lnameCol.setCellValueFactory(new PropertyValueFactory<>("Lname"));
		//		adressCol.setCellValueFactory(new PropertyValueFactory<>("Adress"));
		//		phoneCol.setCellValueFactory(new PropertyValueFactory<>("Phone"));
		//		zipCol.setCellValueFactory(new PropertyValueFactory<>("Zip"));
		//		cityCol.setCellValueFactory(new PropertyValueFactory<>("City"));
		//		pwdCol.setCellValueFactory(new PropertyValueFactory<>("Psswd"));
		//		rolCol.setCellValueFactory(new PropertyValueFactory<>("Role"));
		//		ObservableList<UserFx> os=UserDAO.mostrarUsers();
		//		table.setItems(os);
	}


	public void loadFxml (ActionEvent event)  {
		changeView("Login.fxml");

	}

	@FXML
		void click(ActionEvent event) {
		changeView("Exams.fxml");
	////		if (event.getSource()==testAlumnoBtn) {
	//////			pan1.toFront();
	////		}else if (event.getSource()==statQuestBtn) {
	//////			pane2.toFront();
	////		}else if (event.getSource()==testBtn) {
	//////			pane3.toFront();
	////		}else if (event.getSource()==btn1) {
	//////			pane4.toFront();
	////		}
		}

	public void loginStudent() {
		changeView("StudentView.fxml");
	}

	public void loginAdmin() {
		changeView("AdminView.fxml");
	}

	public void loginTeacher() {
		changeView("TeacherView.fxml");	
	}

	
	public  void setStage(Stage st) {
		this.stage=st;
	}
	
	public void setScene(Scene sc) {
		this.scene=sc;
	}
	
	public void setParent(Parent pa) {
		this.root=pa;
	}

	public void changeView(String viewName) {
		FXMLLoader fxml=new FXMLLoader(getClass().getClassLoader().getResource("views\\"+viewName));		
		Pane newLoadedPane = null;
		try {
			newLoadedPane =fxml.load();
			newLoadedPane.toFront();
			AnchorPane.setTopAnchor(newLoadedPane, 0.0);
			AnchorPane.setLeftAnchor(newLoadedPane, 0.0);
			AnchorPane.setRightAnchor(newLoadedPane, 0.0);
			AnchorPane.setBottomAnchor(newLoadedPane, 0.0);
			views.getChildren().add(newLoadedPane);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}




}
