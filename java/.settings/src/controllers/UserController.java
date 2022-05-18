package controllers;


import java.net.URL;
import java.util.ResourceBundle;

import dao.UserDAO;
import javafx.scene.control.Button;
import javafx.scene.control.PasswordField;
import javafx.scene.control.TextField; 
import javafx.event.ActionEvent;
import javafx.fxml.FXML; 
import javafx.fxml.Initializable; 
import main.Main;
import model.User; 

public class UserController implements Initializable {


	@FXML
	private PasswordField pwdText;

	@FXML
	private TextField fnameText,lnameText,nifText,phoneText,adressText,zipText,emailText,cityText,userNameText;

	@FXML
	private Button saveBtn,cancelBtn,currentUserInfo,logOutBtn;

	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		User usr = Main.getCurrentUser();
		fnameText.setText(usr.getFname());
		lnameText.setText(usr.getLname());
		nifText.setText(usr.getNif());
		emailText.setText(usr.getEmail());
		cityText.setText(usr.getCity());
		zipText.setText(usr.getZip());
		phoneText.setText(usr.getPhone());
		lnameText.setText(usr.getLname()); 
		userNameText.setText(usr.getUserName());
		adressText.setText(usr.getAdress());
		pwdText.setText(usr.getPsswd());
	}

	/***
	 * Activar los campos que muestran la info del usuario
	 * @param event
	 */
	public void activeTextBoxes(ActionEvent event) {
	enableDisableEditing(true);
		Main.getHomeController().showNotification("Los campos esta desactivados, si quieres editar algun acmpo presione el boton de editar.", "#82DBD8");
		
	}
	
	public void enableDisableEditing(boolean editable) {
		fnameText.setEditable(editable);
		lnameText.setEditable(editable);
		nifText.setEditable(editable);
		emailText.setEditable(editable);
		cityText.setEditable(editable);
		zipText.setEditable(editable);
		phoneText.setEditable(editable);
		adressText.setEditable(editable);
		pwdText.setEditable(editable);
		userNameText.setEditable(editable);
		saveBtn.setVisible(editable);
		cancelBtn.setVisible(editable);
	}

	/**
	 * guradar los cambios
	 * @param event
	 */
	public void save(ActionEvent event) { 
		String[] userInfo= {nifText.getText(), fnameText.getText(), lnameText.getText(), adressText.getText(), cityText.getText(),zipText.getText(), phoneText.getText(),emailText.getText()};
		UserDAO.updateUser(userInfo,Main.getCurrentUser().getUserName());
		UserDAO.changePasswd(Main.getCurrentUser().getUserName(),pwdText.getText());
		UserDAO.changeUserName(Main.getCurrentUser().getUserName(), userNameText.getText());
		Main.getHomeController().showNotification("Se han guardado los cambio con exito.", "#00FFAB");
		
	}

	@FXML
	public void cancel(ActionEvent event) {
		Main.getHomeController().redirectHomeView();
	}

}
