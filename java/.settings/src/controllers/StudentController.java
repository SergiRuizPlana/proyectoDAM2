package controllers;


import java.io.IOException;
import java.net.URL;
import java.util.ArrayList;
import java.util.List;
import java.util.ResourceBundle;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;


import dao.QuestionDAO;
import dao.StatExamDAO;
import dao.StatQuestionDAO;
import dao.TopicDAO;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Node;
import javafx.scene.control.Button;
import javafx.scene.control.CheckBox;
import javafx.scene.control.ComboBox;
import javafx.scene.control.RadioButton;
import javafx.scene.control.ScrollPane;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextArea;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.text.Text;
import main.Main;
import javafx.scene.layout.AnchorPane; 
import javafx.scene.layout.VBox;
import model.Question;
import model.StatExam;
import model.Topic;


public class StudentController implements Initializable{

	@FXML
	private Button confirmBtn,submitExambtn,newExam,returnBtn;

	@FXML
	private CheckBox allTopics;

	@FXML
	private RadioButton thirtyQuestionCheck, twentyQuestionCheck;

	@FXML
	private ComboBox<Topic> topicsList;

	@FXML
	private ScrollPane questionsPane;

	@FXML
	private VBox questionsList;

	@FXML
	private AnchorPane questionsListPane,examForm,examsInfo,loadingPane;

	@FXML
	private Text totalQuestions,totalExams;

	@FXML
	private TableColumn<StatExam, String> blankCol,hitsCol,missesCol,topicCol,dateCol,studentCol;

	@FXML
	private TableView<StatExam> examsStatsTable; 

	private List<Question> examQuestions;



	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		topicsList.getItems().addAll(TopicDAO.getAll());
		topicCol.setCellValueFactory(new PropertyValueFactory<>("topic"));
		hitsCol.setCellValueFactory(new PropertyValueFactory<>("hits"));
		missesCol.setCellValueFactory(new PropertyValueFactory<>("misses"));
		blankCol.setCellValueFactory(new PropertyValueFactory<>("blank"));
		dateCol.setCellValueFactory(new PropertyValueFactory<>("statDate"));
		updateData();
	}

	/***
	 * debloquear o bloquear el combobox de topics al seleccionar o deseleccionar el checkbox de all topics
	 * @param event
	 */
	@FXML
	void onCheck(ActionEvent event) {
		if(allTopics.isSelected()) {
			topicsList.setDisable(true);
		}else {
			topicsList.setDisable(false);
		}
	}


	@FXML 
	private void click(ActionEvent event) {
		if(event.getSource()==newExam) {
			examForm.toFront();
		}else if(event.getSource()==returnBtn) {
			examsInfo.toFront();
			Main.getHomeController().changeView("exams\\StudentExamView.fxml",false);
		}
	}

	/***
	 * Generar el examen
	 * @param event
	 * @throws InterruptedException
	 */
	@FXML
	void startExam(ActionEvent event) throws InterruptedException {

		if(allTopics.isSelected()|| topicsList.getSelectionModel().getSelectedItem()!=null) {

			//Comprobar el tipo de examen a realizar
			if(twentyQuestionCheck.isSelected()) {
				if(allTopics.isSelected()) {
					examQuestions=QuestionDAO.obtainLimitedQuestionList(20);
				}else {
					examQuestions=QuestionDAO.obtainLimitedQuestionListByTopic(20,topicsList.getSelectionModel().getSelectedItem().getId());
				}
			}else {
				if(allTopics.isSelected()) {
					examQuestions=QuestionDAO.obtainLimitedQuestionList(30);
				}else {
					examQuestions=QuestionDAO.obtainLimitedQuestionListByTopic(30,topicsList.getSelectionModel().getSelectedItem().getId());
				}
			}
			questionsListPane.toFront();
			int index=1;


			for (Question question : examQuestions) {
				AnchorPane questionPane=new AnchorPane();

				try {
					questionPane = new FXMLLoader(getClass().getClassLoader().getResource("views\\question\\QuestionForm.fxml")).load();

					((Text)questionPane.getChildren().get(5)).setText(index+")");

					((TextArea)questionPane.getChildren().get(0)).setText(question.getQuestion());
					((CheckBox)questionPane.getChildren().get(1)).setText(question.getAnswer1());
					((CheckBox)questionPane.getChildren().get(1)).setOnAction(new EventHandler<ActionEvent>() {
						public void handle(ActionEvent event) {
							checkChange(event);
						}
					});

					((CheckBox)questionPane.getChildren().get(2)).setText(question.getAnswer2());
					((CheckBox)questionPane.getChildren().get(2)).setOnAction(new EventHandler<ActionEvent>() {
						public void handle(ActionEvent event) {
							checkChange(event);
						}
					});

					if(!question.getAnswer3().equals("")) {
						((CheckBox)questionPane.getChildren().get(3)).setText(question.getAnswer3());		
						((CheckBox)questionPane.getChildren().get(3)).setOnAction(new EventHandler<ActionEvent>() {
							public void handle(ActionEvent event) {
								checkChange(event);
							}
						});

						if(!question.getAnswer4().equals("")) {
							((CheckBox)questionPane.getChildren().get(4)).setText(question.getAnswer4());	
							((CheckBox)questionPane.getChildren().get(4)).setOnAction(new EventHandler<ActionEvent>() {
								public void handle(ActionEvent event) {
									checkChange(event);
								}
							});
						}else {
							questionPane.getChildren().remove(4);
							//						questionPane.setPrefHeight(questionPane.getHeight()-25);
						}

					}else {
						questionPane.getChildren().remove(3);
						questionPane.getChildren().remove(3);
						//					questionPane.setPrefHeight(questionPane.getHeight()-40);
					}

				} catch (IOException e) {

					e.printStackTrace();
				}
				questionsList.getChildren().add(questionPane);
				index++;
			}

			ExecutorService service = Executors.newFixedThreadPool(4);
			service.submit(new Runnable() {
				public void run() {
//					for (Question question : examQuestions) {
////						StatQuestionDAO.insertStatQuestion(question.getId_question(),Main.getCurrentUser().getNif(),0, 0, 0);
//					}		
					service.shutdownNow();
				}
			});

		}else {
			Main.getHomeController().showNotification("Debes seleccionar una tematica o un examen aleatorio","#82DBD8");
		}
	}




	/***
	 * genera el resultado de un examen
	 * @param event
	 */
	@FXML
	void submitExam(ActionEvent event) {
		loadingPane.toFront();
		int[] results=new int[3];
		String nif =Main.currentUser.getNif();


		int i =0;
		for (Node node : 	questionsList.getChildren()) {
			int hint=0,misse=0,blank=0;

			CheckBox ch1=(CheckBox)((AnchorPane)node).getChildren().get(1);
			CheckBox ch2=(CheckBox)((AnchorPane)node).getChildren().get(2);
			CheckBox ch3=null;
			CheckBox ch4=null;
			if(((AnchorPane)node).getChildren().get(3).getClass().equals(CheckBox.class)) {
				ch3=(CheckBox)((AnchorPane)node).getChildren().get(3);
				if(((AnchorPane)node).getChildren().get(4).getClass().equals(CheckBox.class)) {
					ch4=(CheckBox)((AnchorPane)node).getChildren().get(4);
				}
			}

			if(((CheckBox)((AnchorPane)node).getChildren().get(examQuestions.get(i).getCorrectanswer())).isSelected()){
				results[0]++;
				hint=1;
				((CheckBox)((AnchorPane)node).getChildren().get(examQuestions.get(i).getCorrectanswer())).setStyle("-fx-text-fill: green");

			}else if(ch1.isSelected()) {
				results[1]++;
				misse=1;
				ch1.setStyle("-fx-text-fill:red");
			}else if(ch2.isSelected()) {
				results[1]++;
				misse=1;
				ch2.setStyle("-fx-text-fill:red");
			}else if(ch3!=null) {
				if(ch3.isSelected()) {
					results[1]++;
					misse=1; 
					ch3.setStyle("-fx-text-fill:red");
				}else  if(ch4!=null) {
					if(ch4.isSelected()) {
						results[1]++;
						misse=1;
						ch4.setStyle("-fx-text-fill:red");
					}else {
						results[2]++;
						blank=1;
					}
				}else {
					results[2]++;
					blank=1;
				}
			}else {
				results[2]++;
				blank=1;
			}

			String idQuestion=examQuestions.get(i).getId_question();

			StatQuestionDAO.updateStatQuestion(idQuestion, nif,hint, misse, blank);

			i++;

		}

		String idTopic="";

		if(!allTopics.isSelected()) {
			idTopic=topicsList.getSelectionModel().getSelectedItem().getId();
		} 
		StatExamDAO.insertStatExam(nif, results[0], results[1], results[2],idTopic) ;

		returnBtn.setVisible(true);
		submitExambtn.setVisible(false);
		updateData();
		loadingPane.toBack();
	}



	/***
	 * Desmarcar el checkbox marcado al seleccionar otro de una misma pregunta
	 * @param event
	 */
	public void checkChange(ActionEvent event) {
		List <CheckBox>checkBoxes=new ArrayList<CheckBox>();

		CheckBox ch=  (CheckBox)event.getSource();
		AnchorPane ap=(AnchorPane)ch.getParent();
		try {
			checkBoxes.add((CheckBox)ap.getChildren().get(1));
			checkBoxes.add((CheckBox)ap.getChildren().get(2));
			checkBoxes.add((CheckBox)ap.getChildren().get(3));
			checkBoxes.add((CheckBox)ap.getChildren().get(4));
		} catch (Exception e) {
			// TODO: handle exception
		}
		for (CheckBox checkBox : checkBoxes) {
			if(checkBox.equals(ch) && ch.isSelected() ) {
				ch.setSelected(true);                
			}else {
				checkBox.setSelected(false);                
			}
		}

	}

	public void updateData() {
		totalExams.setText(StatExamDAO.getTotalExams(Main.getCurrentUser().getNif())+"");
		totalQuestions.setText(StatQuestionDAO.getTotalQuestions(Main.getCurrentUser().getNif())+"");
		examsStatsTable.getItems().clear();
		examsStatsTable.getItems().addAll(StatExamDAO.obtainLastFive(Main.getCurrentUser().getNif()));
	}



}
