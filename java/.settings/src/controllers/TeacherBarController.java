package controllers;
 
import java.net.URL;
import java.util.ResourceBundle; 
import javafx.event.ActionEvent;
import javafx.fxml.FXML; 
import javafx.fxml.Initializable; 
import javafx.scene.control.Button;  
import test.Test;

public class TeacherBarController implements Initializable{



	@FXML
	private Button showStudentBtn;






	@FXML
	private Button questionsBtn;

	@FXML
	private Button statsBtn;

	@FXML
	private Button studentBtn;

	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
	
	}


	
	public void click(ActionEvent event) {
		if(event.getSource()==studentBtn) {
			Test.getHomeController().changeView("teacher\\TeacherView.fxml", false);	
		}else if(event.getSource()==questionsBtn) {
			Test.getHomeController().changeView("question\\QuestionsList.fxml", false);
		}else if(event.getSource()==statsBtn) {
			Test.getHomeController().changeView("stadistics\\TeacherStatsView.fxml", false);
		}
		
		
		
	}
	




}
