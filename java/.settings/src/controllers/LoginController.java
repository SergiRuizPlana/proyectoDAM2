package controllers;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;
import java.util.TreeMap;

import dao.UserDAO;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.PasswordField;
import javafx.scene.control.TextField;
import model.User;
import test.Test;

public class LoginController implements Initializable {



	@FXML
	private Button login;

	@FXML
	private PasswordField pwd;

	@FXML
	private TextField username;


	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		// TODO Auto-generated method stub

	}

	@FXML
	public void logClick(ActionEvent event) throws IOException {

//		User user = UserDAO.checkCredentials(username.getText(), pwd.getText());
		Test.getHomeController().loginTeacher();			
		//				if(user!=null) {
		//					if(user.getRole().equalsIgnoreCase("ADMIN")) {
		//						Test.getHomeController().loginAdmin();					
		//					}else if(user.getRole().equalsIgnoreCase("TEACHER")) {
		//						Test.getHomeController().loginTeacher();					
		//					}else if(user.getRole().equalsIgnoreCase("STUDENT")) {
		//						Test.getHomeController().loginStudent();						
		//					}
		//			
		//		}
	}






}
