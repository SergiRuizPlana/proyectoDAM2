package controllers;


import java.net.URL; 
import java.util.List;
import java.util.ResourceBundle;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

import dao.StatExamDAO;
import dao.StatQuestionDAO;
import dao.TopicDAO;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.CheckBox;
import javafx.scene.control.ComboBox;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextField;
import javafx.scene.control.cell.PropertyValueFactory; 
import main.Main;
import model.StatExam;
import model.StatQuestion;
import model.Topic; 
public class StatsController implements  Initializable{

	@FXML
	private TableColumn<StatExam, String> blankCol,hitsCol,missesCol,topicCol,dateCol,studentCol;

	@FXML
	private TableColumn<StatQuestion, String> blankStatQCol,descriptioStatQCol,hitsStatQCol,missesStatQCol,topicStatQCol,studentStatQCol;

	@FXML
	private Button changeStatBtn,returnBtn,searchBtn;

	@FXML
	private TableView<StatExam> examsStatsTable;

	@FXML
	private TableView<StatQuestion> statQuestionTable;

	@FXML
	private ComboBox<Topic> topicSearch;

	@FXML 
	private CheckBox studentCheck,topicCheck;

	@FXML TextField studentSearch;

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

		if(Main.getCurrentUser().isTeacher()) {
			studentCol.setCellValueFactory(new PropertyValueFactory<>("student"));
			studentStatQCol.setCellValueFactory(new PropertyValueFactory<>("student"));
		}

		ExecutorService service = Executors.newFixedThreadPool(4);
		service.submit(new Runnable() {
			public void run() {
				if(Main.getCurrentUser().isTeacher()) {
					examsStatsTable.getItems().addAll(StatExamDAO.obtainAllStats());
					statQuestionTable.getItems().addAll(StatQuestionDAO.getAll());
				}else {
					examsStatsTable.getItems().addAll(StatExamDAO.obtainAllStatsByUser(Main.getCurrentUser().getNif()));
					statQuestionTable.getItems().addAll(StatQuestionDAO.obtainByUser(Main.getCurrentUser().getNif()));					
				}
				service.shutdownNow();
			}
		});
 
	}

	@FXML
	
	public void checkChanged(ActionEvent event) {
		if(studentCheck.isSelected()) {
			studentSearch.setDisable(false);
		}else {
			studentSearch.setDisable(true);
		}
		if(topicCheck.isSelected()) {
			topicSearch.getItems().clear();
			topicSearch.getItems().addAll(TopicDAO.getAll());
			topicSearch.setDisable(false);
		}else {
			topicSearch.setDisable(true);
		}
		
	}
	
	
	/***
	 * busqueda por usuario o tematica
	 */
	@FXML
	private void updateData(ActionEvent event) {
		examsStatsTable.getItems().clear();
		statQuestionTable.getItems().clear();
		
		ExecutorService service = Executors.newFixedThreadPool(4);
		service.submit(new Runnable() {
			public void run() {
				if(studentCheck.isSelected() && topicCheck.isSelected()) {
					examsStatsTable.getItems().addAll(StatExamDAO.obtainByNameAndTopic(studentSearch.getText(), topicSearch.getSelectionModel().getSelectedItem().getId()));
					statQuestionTable.getItems().addAll(StatQuestionDAO.obtainByTopicAndName(topicSearch.getSelectionModel().getSelectedItem(),studentSearch.getText()));
				}else if(studentCheck.isSelected()) {
					examsStatsTable.getItems().addAll(StatExamDAO.obtainAllStatsByUser(studentSearch.getText()));
					statQuestionTable.getItems().addAll(StatQuestionDAO.obtainByName(studentSearch.getText()));
				}else if(topicCheck.isSelected()) {
					examsStatsTable.getItems().addAll(StatExamDAO.obtainAllStatsByTopic(topicSearch.getSelectionModel().getSelectedItem()));
					statQuestionTable.getItems().addAll(StatQuestionDAO.obtainByTopic(topicSearch.getSelectionModel().getSelectedItem()));
				}else {
					examsStatsTable.getItems().addAll(StatExamDAO.obtainAllStats());
					statQuestionTable.getItems().addAll(StatQuestionDAO.getAll());
				}
				
				service.shutdownNow();
			}
		});
	}

}
