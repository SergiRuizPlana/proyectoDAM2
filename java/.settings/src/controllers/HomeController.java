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
import javafx.scene.SubScene;
import javafx.scene.control.Button;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.Pane;
import javafx.scene.layout.StackPane;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;
import model.User;
import model.UserFx;

public class HomeController implements Initializable {

	private static User currentUser;


	@FXML
	private BorderPane homeBorderPane;
	

	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		changeView("Login.fxml",false);
	}


	public void loadFxml (ActionEvent event)  {
		changeView("Login.fxml",true);

	}

	@FXML
	void click(ActionEvent event) {
		changeView("Exams.fxml",false);
		
	}

	public void loginStudent() {
		changeView("student\\StudentView.fxml",false);
	}

	public void loginAdmin() {
		changeView("AdminView.fxml",false);
	}

	public void loginTeacher() {
		changeView("teacher\\TeacherControlBar.fxml",true);	
		changeView("teacher\\TeacherView.fxml",false);	
	}



	public void changeView(String viewName,boolean isControlTab) {
		FXMLLoader fxml=new FXMLLoader(getClass().getClassLoader().getResource("views\\"+viewName));		
		try {
			if(isControlTab) {
				VBox vbox =fxml.load();
				homeBorderPane.setLeft(vbox);
			}else {
				AnchorPane aPane =fxml.load();
				homeBorderPane.setCenter(aPane);			
			}
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}




}
