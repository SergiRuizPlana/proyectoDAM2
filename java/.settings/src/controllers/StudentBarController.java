package controllers;

import java.net.URL;
import java.util.ResourceBundle;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;

import javafx.scene.control.Button;

import test.Test;

public class StudentBarController implements Initializable{

	@FXML
	private Button examsBtn,statsExamsBtn,statsQuesdtionBtn;



	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {

	}

	public void click(ActionEvent event) {
		if(event.getSource()==examsBtn) {
			Test.getHomeController().changeView("exams\\StudentExamView.fxml", false);
		}else if(event.getSource()==statsExamsBtn) {
			Test.getHomeController().changeView("stadistics\\StudentStatsView.fxml", false);
		}else if(event.getSource()==statsQuesdtionBtn) {
			Test.getHomeController().changeView("question\\StatQuestionsList.fxml", false);
		} 	
	}
	
 
}
