package controllers;


import java.net.URL;
import java.util.ResourceBundle;


import javafx.scene.control.Button; 	
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
public class HomeController implements Initializable {

	@FXML
	private BorderPane homeBorderPane;

	@FXML
	private ImageView img;

	@FXML
	private Button currentUserInfo,logOutBtn;

	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		img.setVisible(true);
		changeView("Login.fxml",false);
	}




	@FXML
	void click(ActionEvent event) {
		changeView("Exams.fxml",false);

	}

	public void loginSucces(User user) { 
		
		Test.getHomeController().setCurrentUserName(user.getFname());
		
		if(user.getRole().equalsIgnoreCase("ADMIN")) {
			changeView("AdminView.fxml",false);		
			
		}else if(user.getRole().equalsIgnoreCase("TEACHER")) {
			changeView("teacher\\TeacherControlBar.fxml",true);	
			changeView("teacher\\TeacherView.fxml",false);		
			
		}else if(user.getRole().equalsIgnoreCase("STUDENT")) { 							
			changeView("student\\StudentControlBar.fxml",true);	
			changeView("exams\\StudentExamView.fxml",false);
			
		}
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



	@FXML 
	public void showUserInfo() {			
		changeView("UserForm.fxml", false);
	}

	public void setCurrentUserName(String name) {
		currentUserInfo.setText(name);
		currentUserInfo.setVisible(true);
		logOutBtn.setVisible(true);
	}


	@FXML
	public void logOut(ActionEvent event) {
		homeBorderPane.setLeft(null);
		changeView("Login.fxml", false);
	}
	
	public void redirectHomeView() {
		loginSucces(Test.getCurrentUser());
	}

}
