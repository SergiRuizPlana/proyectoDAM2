package controllers;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle; 
import dao.UserDAO;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.PasswordField;
import javafx.scene.control.TextField; 
import javafx.scene.text.Text;
import main.Main;
import model.User;

public class LoginController implements Initializable {


	@FXML
	private Button login;

	@FXML
	private PasswordField pwd;

	@FXML
	private TextField username;

	@FXML
	private Text infoMessage;

	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		 
	}

	
	/***
	 * Comprobar despues de insertar los datos si el usuario existe o no. en el caso de que existe llama a la funcion que muestra la vista que toca
	 * @param event
	 * @throws IOException
	 */
	@FXML
	public void logClick(ActionEvent event) throws IOException { 
		if(!username.getText().equals("") && !pwd.getText().equals("")) {
			User user = UserDAO.checkCredentials(username.getText(), pwd.getText());
			Main.setCurrentUser(user);
			if(user!=null) {
				Main.getHomeController().loginSucces(user);
				Main.setCurrentUser(user);
			}else {
				infoMessage.setText("Usuario o contraseña no validos!!");			
			} 
		}else {
			if(username.getText().equals("")) {
				infoMessage.setText("El campo Usuario no debe ser vacio!");							
			}else if(pwd.getText().equals("")) {
				infoMessage.setText("El campo contraseña no debe ser vacio!");							
			}else {
				infoMessage.setText("Los campos Usuarioy contraseña no deben ser vacios!");							
			}
		}
	}


}
