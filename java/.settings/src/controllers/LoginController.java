package controllers;

import java.io.IOException;
import java.net.URL;
import java.util.Map;
import java.util.ResourceBundle;
import java.util.TreeMap;

import dao.UserDAO;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.PasswordField;
import javafx.scene.control.TextField;
import javafx.stage.Stage;
import jdk.incubator.vector.VectorOperators.Test;

public class LoginController implements Initializable {

	private Stage stage;
	private Scene scene;
	private Parent root;

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
		TreeMap users=UserDAO.getUsers();
		
		System.out.println(username.getText() +" asda "+ pwd.getText());
		if (users.containsKey(username.getText())) {
			if(users.get(username.getText()).equals(pwd.getText())){
				test.Test.getHomeController().loginStudent();;			
			}
		}
	}
	
	
	
	
	
	
}
