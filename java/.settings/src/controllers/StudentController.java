package controllers;


import java.io.IOException;
import java.net.URL;
import java.util.ArrayList;
import java.util.Collections;
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
import javafx.scene.control.TextArea;
import javafx.scene.text.Text;
import javafx.scene.layout.AnchorPane; 
import javafx.scene.layout.VBox;
import model.Question;
import model.Topic;
import test.Test;
public class StudentController implements Initializable{

	@FXML
	private Button confirmBtn,submitExambtn;

	@FXML
	private CheckBox allTopics;

	@FXML
	private RadioButton thirtyQuestionCheck, twentyQuestionCheck;

	@FXML
	private ComboBox<Topic> topicsList;

	@FXML
	private ScrollPane questionsPane;

	private List<Question> examQuestions;


	@FXML
	private VBox questionsList;


	@FXML
	private AnchorPane questionsListPane,loadAnim;



	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		topicsList.getItems().addAll(TopicDAO.getAll());
	}


	@FXML
	void onCheck(ActionEvent event) {
		if(allTopics.isSelected()) {
			topicsList.setDisable(true);
		}else {
			topicsList.setDisable(true);
		}
	}


	@FXML
	void startExam(ActionEvent event) throws InterruptedException {

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
			System.out.println(index+ "  "+question);
			index++;
		}

		ExecutorService service = Executors.newFixedThreadPool(4);
		service.submit(new Runnable() {
			public void run() {
				for (Question question : examQuestions) {
					StatQuestionDAO.insertStatQuestion(question.getId_question(),Test.getCurrentUser().getNif(),0, 0, 0);
				}		
				service.shutdownNow();
			}
		});

		loadAnim.toBack();
	}





	@FXML
	void submitExam(ActionEvent event) {
		int[] results=new int[3];
		String nif =Test.currentUser.getNif();

		ExecutorService service = Executors.newFixedThreadPool(4);
		service.submit(new Runnable() {
			public void run() {
				int i =0;
				for (Node node : 	questionsList.getChildren()) {
					int hint=0,misse=0,blank=0;

					CheckBox ch1=(CheckBox)((AnchorPane)node).getChildren().get(1);
					CheckBox ch2=(CheckBox)((AnchorPane)node).getChildren().get(2);
					CheckBox ch3=null;

					if(((AnchorPane)node).getChildren().size()>3) {
						ch3=(CheckBox)((AnchorPane)node).getChildren().get(3);
					}
					CheckBox ch4=null;
					if(((AnchorPane)node).getChildren().size()>4) {
						ch4=(CheckBox)((AnchorPane)node).getChildren().get(4);
					}

					if(((CheckBox)((AnchorPane)node).getChildren().get(examQuestions.get(i).getCorrectanswer())).isSelected()){
						results[0]++;
						hint=1;
					}else if(ch1.isSelected()) {
						results[1]++;
						misse=1;
						ch1.setStyle("");
					}else if(ch2.isSelected()) {
						results[1]++;
						misse=1;
						ch2.setStyle("");
					}else if(ch3!=null) {
						if(ch3.isSelected()) {
							results[1]++;
							misse=1;
							misse=1;
							ch3.setStyle("");
						}else  if(ch4!=null) {
							if(ch4.isSelected()) {
								results[1]++;
								misse=1;
								ch4.setStyle("");
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
				service.shutdownNow();
			}
		});

		String idTopic="";
		if(!allTopics.isSelected()) {
			idTopic=topicsList.getSelectionModel().getSelectedItem().getId();
		}

		StatExamDAO.insertStatExam(nif, results[0], results[1], results[2],idTopic) ;
		loadAnim.toBack();
	}


	public void checkChange(ActionEvent event) {
		List <CheckBox>checkBoxes=new ArrayList<CheckBox>();

		CheckBox ch=  (CheckBox)event.getSource();
		AnchorPane ap=(AnchorPane)ch.getParent();
		try {
			checkBoxes.add((CheckBox)ap.getChildren().get(1));
			checkBoxes.add((CheckBox)ap.getChildren().get(2));
			checkBoxes.add((CheckBox)ap.getChildren().get(3));
			checkBoxes.add((CheckBox)ap.getChildren().get(4));
			System.out.println(((CheckBox)ap.getChildren().get(1)).getText());
			System.out.println(((CheckBox)ap.getChildren().get(2)).getText());
			System.out.println(((CheckBox)ap.getChildren().get(3)).getText());
			System.out.println(((CheckBox)ap.getChildren().get(4)).getText());
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


}
