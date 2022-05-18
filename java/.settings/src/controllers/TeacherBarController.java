package controllers;
 
import java.net.URL;
import java.util.ResourceBundle; 
import javafx.event.ActionEvent;
import javafx.fxml.FXML; 
import javafx.fxml.Initializable; 
import javafx.scene.control.Button;
import main.Main;

public class TeacherBarController implements Initializable{



	@FXML
	private Button showStudentBtn,questionsBtn,statsBtn,studentBtn,topicsBtn;


	
	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
	
	}

/***
 * Muestra cada vista depende del boton presionado
 * @param event
 */
	@FXML
	public void click(ActionEvent event) {
		if(event.getSource()==studentBtn) {
			Main.getHomeController().changeView("teacher\\TeacherView.fxml", false);	
		}else if(event.getSource()==questionsBtn) {
			Main.getHomeController().changeView("question\\QuestionsList.fxml", false);
		}else if(event.getSource()==statsBtn) {
			Main.getHomeController().changeView("stadistics\\TeacherStatsView.fxml", false);
		}else if(event.getSource()==topicsBtn) {
			Main.getHomeController().changeView("topics\\TopicsView.fxml", false);
		}
		
		
		
	}
	




}
