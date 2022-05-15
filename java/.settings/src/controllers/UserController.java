package controllers;


import java.net.URL;
import java.util.ResourceBundle;

import dao.UserDAO;
import javafx.scene.control.Button;
import javafx.scene.control.PasswordField;
import javafx.scene.control.TextField;
import javafx.scene.image.Image;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.image.ImageView;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.VBox;
import model.User;
import test.Test;
import utils.ControlUtils; 
public class UserController implements Initializable {


	@FXML
	private PasswordField pwdText;

	@FXML
	private TextField fnameText,lnameText,nifText,phoneText,adressText,zipText,emailText,cityText,userNameText;

	@FXML
	private Button saveBtn,cancelBtn,currentUserInfo,logOutBtn;

	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		User usr = Test.getCurrentUser();
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

	public void activeTextBoxes(ActionEvent event) {
		fnameText.setEditable(true);
		lnameText.setEditable(true);
		nifText.setEditable(true);
		emailText.setEditable(true);
		cityText.setEditable(true);
		zipText.setEditable(true);
		phoneText.setEditable(true);
		adressText.setEditable(true);
		pwdText.setEditable(true);
		userNameText.setEditable(true);
		saveBtn.setVisible(true);
		cancelBtn.setVisible(true);
	}

	public void save(ActionEvent event) { 
		String[] userInfo= {nifText.getText(), fnameText.getText(), lnameText.getText(), adressText.getText(), cityText.getText(),zipText.getText(), phoneText.getText(),emailText.getText()};
		UserDAO.updateUser(userInfo,Test.getCurrentUser().getUserName());
		UserDAO.changePasswd(Test.getCurrentUser().getUserName(),pwdText.getText());
		UserDAO.changeUserName(Test.getCurrentUser().getUserName(), userNameText.getText());
	}

	@FXML
	public void cancel(ActionEvent event) {
		Test.getHomeController().redirectHomeView();
	}

}
