package controllers;


import java.net.URL;
import java.util.Calendar;
import java.util.List;
import java.util.ResourceBundle;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

import dao.StatExamDAO;
import dao.StatQuestionDAO;
import dao.TopicDAO;
import dao.UserDAO;
import javafx.beans.property.SimpleStringProperty;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.StackPane;
import model.StatExam;
import model.StatQuestion;
import model.Topic;
import test.Test;

public class StatsController implements  Initializable{

	@FXML
	private TableColumn<StatExam, String> blankCol,hitsCol,missesCol,topicCol,dateCol,studentCol;

	@FXML
	private TableColumn<StatQuestion, String> blankStatQCol,descriptioStatQCol,hitsStatQCol,missesStatQCol,topicStatQCol,studentStatQCol;

	@FXML
	private Button changeStatBtn,returnBtn;
 

	@FXML
	private TableView<StatExam> examsStatsTable;

	@FXML
	private TableView<StatQuestion> statQuestionTable;

 
	List <StatQuestion> list=null;

	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {


		topicCol.setCellValueFactory(new PropertyValueFactory<>("topic"));
		hitsCol.setCellValueFactory(new PropertyValueFactory<>("hits"));
		missesCol.setCellValueFactory(new PropertyValueFactory<>("misses"));
		blankCol.setCellValueFactory(new PropertyValueFactory<>("blank"));
		dateCol.setCellValueFactory(new PropertyValueFactory<>("statDate"));

		topicStatQCol.setCellValueFactory(new PropertyValueFactory<>("topic"));
		descriptioStatQCol.setCellValueFactory(new PropertyValueFactory< >("question"));
		hitsStatQCol.setCellValueFactory(new PropertyValueFactory< >("total_hits"));
		missesStatQCol.setCellValueFactory(new PropertyValueFactory<>("total_misses"));
		blankStatQCol.setCellValueFactory(new PropertyValueFactory<>("total_blank"));

		if(Test.getCurrentUser().isTeacher()) {
			studentCol.setCellValueFactory(new PropertyValueFactory<>("student"));
			studentStatQCol.setCellValueFactory(new PropertyValueFactory<>("student"));
		}
		ExecutorService service = Executors.newFixedThreadPool(4);
		service.submit(new Runnable() {
			public void run() {
				if(Test.getCurrentUser().isTeacher()) {
					examsStatsTable.getItems().addAll(StatExamDAO.obtainAllStats());
					statQuestionTable.getItems().addAll(StatQuestionDAO.getAll());
				}else {
					examsStatsTable.getItems().addAll(StatExamDAO.obtainAllStatsByUser(Test.getCurrentUser().getNif()));
					statQuestionTable.getItems().addAll(StatQuestionDAO.obtainByUser(Test.getCurrentUser().getNif()));					
				}
				service.shutdownNow();
			}
		});


	}
 

}
