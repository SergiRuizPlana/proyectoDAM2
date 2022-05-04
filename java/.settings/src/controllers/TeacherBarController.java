package controllers;

import java.io.File;
import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;

import javax.swing.JFileChooser;

import dao.UserDAO;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.geometry.Insets;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button; 
import javafx.scene.control.TableCell;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextField;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.AnchorPane; 
import javafx.scene.layout.HBox;
import javafx.scene.layout.VBox;
import javafx.stage.FileChooser;
import javafx.stage.Stage;
import javafx.util.Callback; 
import model.UserFx;
import test.Test;

public class TeacherBarController implements Initializable{



	@FXML
	private Button showStudentBtn;




	@FXML
	private Button examsBtn;

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
		}else if(event.getSource()==examsBtn) {
			Test.getHomeController().changeView("exams\\ExamsList.fxml", false);
		}else if(event.getSource()==questionsBtn) {
			Test.getHomeController().changeView("questions\\QuestionsList.fxml", false);
		}else if(event.getSource()==statsBtn) {
			Test.getHomeController().changeView("student\\StatsList.fxml", false);
		}
		
		
		
	}
	




}
