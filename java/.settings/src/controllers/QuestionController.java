package controllers;

import java.io.File;
import java.io.IOException;
import java.net.URL;
import java.util.List;
import java.util.ResourceBundle;

import dao.QuestionDAO;
import dao.TopicDAO;
import javafx.beans.property.SimpleStringProperty;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.geometry.Insets;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.CheckBox;
import javafx.scene.control.TextArea;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.HBox;
import javafx.scene.text.Text;
import javafx.stage.FileChooser;
import javafx.stage.Stage;
import javafx.util.Callback;
import javafx.scene.control.ComboBox;
import javafx.scene.control.RadioButton;
import javafx.scene.control.TableCell;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import model.Question;
import model.Topic;
import test.Test;
import utils.ControlUtils;

public class QuestionController implements Initializable {


	@FXML
	private TextArea answerText1,answerText2, answerText3, answerText4, questionText;

	@FXML
	private Text idQuestionText;
	
	@FXML
	private TextArea answerText1Edit,answerText2Edit, answerText3Edit, answerText4Edit, questionTextEdit,idQuestionTextEdit,questionTextEditEdit;

	@FXML
	private AnchorPane createPane,editPane,listPane;

	@FXML
	private Button cancelBtn,saveBtn,importXml,createQuestionBtn,saveEditBtn, cancelEditBtn, EditBtn,deleteBtn;

	@FXML
	private RadioButton correctAnswer1,correctAnswer2, correctAnswer3, correctAnswer4 ;

	@FXML 
	private ComboBox<Topic> topicList;

	@FXML
	private TableColumn<Question, String> questionCol,answersCol,editCol;
	
	@FXML
	private TableColumn<Question, String> topicCol;

	@FXML
	private TableView<Question> questionsList;

	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		// TODO Auto-generated method stub

		if(questionsList!=null) {


			questionCol.setCellValueFactory(new PropertyValueFactory<>("question"));
			 
			
			topicCol.setCellValueFactory(cellData -> new SimpleStringProperty(cellData.getValue().getTopic().getDescription()));

			Callback<TableColumn<Question, String>, TableCell<Question, String>> cellFoctory = (TableColumn<Question, String> param) -> {


				final TableCell<Question, String> cell = new TableCell<Question, String>() {
					@Override
					public void updateItem(String item, boolean empty) {
						super.updateItem(item, empty);
						//that cell created only on non-empty rows
						if (empty) {
							setGraphic(null);
							setText(null);

						} else {

							Button deleteIcon = new Button("rm");
							Button editIcon = new Button("edit");

							deleteIcon.setStyle(
									" -fx-cursor: hand ;"
											+ "-glyph-size:28px;"
											+ "-fx-fill:#ff1744;"
									);
							editIcon.setStyle(
									" -fx-cursor: hand ;"
											+ "-glyph-size:28px;"
											+ "-fx-fill:#00E676;"
									);
							deleteIcon.setOnMouseClicked((MouseEvent event) -> {
								Question qst= getTableRow().getItem();
								if(QuestionDAO.deleteQuestio(qst.getId_question())) {
									questionsList.getItems().remove(qst);
								}
							});

							editIcon.setOnMouseClicked((MouseEvent event) -> {
								Question qst= getTableRow().getItem();
								editPane.toFront(); 
								questionText.setText(qst.getQuestion());
								answerText1.setText(qst.getAnswer1());
								answerText2.setText(qst.getAnswer2());
								answerText3.setText(qst.getAnswer3());
								answerText4.setText(qst.getAnswer4()); 
								idQuestionText.setText(qst.getId_question());
								if(qst.getCorrectanswer()==1) {
									correctAnswer1.setSelected(true);
								}else if(qst.getCorrectanswer()==2) {
									correctAnswer2.setSelected(true);
								}else if(qst.getCorrectanswer()==3) {
									correctAnswer3.setSelected(true);
								}else {
									correctAnswer4.setSelected(true);
								}

								topicList.getItems().addAll(TopicDAO.getAll());
								topicList.getSelectionModel().select(qst.getTopic());
 
							});

							HBox managebtn = new HBox(editIcon, deleteIcon);
							managebtn.setStyle("-fx-alignment:center");
							HBox.setMargin(deleteIcon, new Insets(2, 2, 0, 3));
							HBox.setMargin(editIcon, new Insets(2, 3, 0, 2));
							setGraphic(managebtn);
							setText(null);
						}
					}
				};
				return cell;
			};

			editCol.setCellFactory(cellFoctory);

			questionsList.getItems().addAll(QuestionDAO.obtainFullQuestionList());
		}
	}

	@FXML
	void cancel(ActionEvent event) {
		listPane.toFront();
	}

	
	@FXML
	void delete(ActionEvent event) {
		listPane.toFront();
		QuestionDAO.deleteQuestio(idQuestionText.getText()); 
	}

	
	public void importXmlFile(ActionEvent event) {
		FileChooser fx=new FileChooser();
		//		fx.setSelectedExtensionFilter(null);
		File selectedFile=fx.showOpenDialog(null);
		List <Question> questions=ControlUtils.getQuestionFromXml(selectedFile);
		if(questions!=null) {
			QuestionDAO.addQuestiosList(questions);			
		}
		

	}

	@FXML
	void save(ActionEvent event) {
		Question question= new Question(questionText.getText(), answerText1.getText(), answerText2.getText(), answerText3.getText(), answerText4.getText(), getCorrectIndex(),topicList.getSelectionModel().getSelectedItem());
		if(event.getSource()==saveBtn) {
			QuestionDAO.addQuestio(question);	
			listPane.toFront();
		}else if(event.getSource()==saveEditBtn) {
			question.setId_question(idQuestionText.getText());
		QuestionDAO.updateQuestio(question);
			listPane.toFront();
		}
		
		questionsList.getItems().clear();
		questionsList.getItems().addAll(QuestionDAO.obtainFullQuestionList());
	}

	@FXML
	void selectCorrect(ActionEvent event) {
		correctAnswer1.setSelected(false);
		correctAnswer2.setSelected(false);
		correctAnswer3.setSelected(false);
		correctAnswer4.setSelected(false);

		if(event.getSource()==correctAnswer1) {
			correctAnswer1.setSelected(true);
		}else if(event.getSource()==correctAnswer2) {
			correctAnswer2.setSelected(true);
		}else if(event.getSource()==correctAnswer3) {
			correctAnswer3.setSelected(true);
		}else if(event.getSource()==correctAnswer4) {
			correctAnswer4.setSelected(true);
		}
	}

	@FXML 
	void createQuestion(ActionEvent event) {
		createPane.toFront();
		topicList.getItems().addAll(TopicDAO.getAll());
	}

	@FXML
	void enableEditing(ActionEvent event) {
		questionText.setEditable(true);
		answerText1.setEditable(true);
		answerText2.setEditable(true);
		answerText3.setEditable(true);
		answerText4.setEditable(true);

		correctAnswer1.setDisable(false);
		correctAnswer2.setDisable(false);
		correctAnswer3.setDisable(false);
		correctAnswer4.setDisable(false);

		topicList.setDisable(false);

		saveEditBtn.setVisible(true);
		cancelEditBtn.setVisible(true);
 
	}

 



	private int getCorrectIndex() {
		if(correctAnswer1.isSelected()) {
			return 1;				
		}else 	if(correctAnswer2.isSelected()) {
			return 2;
		}else 	if(correctAnswer3.isSelected()) {
			return 3;
		}else {
			return 4;
		}
	}


}
