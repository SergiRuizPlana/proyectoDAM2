package controllers;

import java.io.File; 
import java.net.URL;
import java.util.List;
import java.util.ResourceBundle;

import dao.QuestionDAO;
import dao.TopicDAO;
import javafx.beans.property.SimpleStringProperty;
import javafx.event.ActionEvent;
import javafx.fxml.FXML; 
import javafx.fxml.Initializable;
import javafx.geometry.Insets; 
import javafx.scene.control.Button; 
import javafx.scene.control.TextArea;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.HBox;
import javafx.scene.text.Text;
import javafx.stage.FileChooser; 
import javafx.util.Callback;
import main.Main;
import javafx.scene.control.ComboBox;
import javafx.scene.control.RadioButton;
import javafx.scene.control.TableCell;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import model.Question;
import model.Topic;
import utils.ControlUtils;

public class QuestionController implements Initializable {


	@FXML
	private TextArea answerText1,answerText2, answerText3, answerText4, questionText;

	@FXML
	private Text idQuestionText;

	@FXML
	private TextArea answerText11,answerText21, answerText31, answerText41, questionText1,idQuestionText1,questionTextEdit1;

	@FXML
	private AnchorPane createPane,editPane,listPane;

	@FXML
	private Button cancelBtn,saveBtn,importXml,createQuestionBtn,saveEditBtn, cancelEditBtn, EditBtn,deleteBtn;

	@FXML
	private RadioButton correctAnswer1,correctAnswer2, correctAnswer3, correctAnswer4,correctAnswer11,correctAnswer21, correctAnswer31, correctAnswer41 ;

	@FXML 
	private ComboBox<Topic> topicList,topicList1;

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

							Image editIgm = new Image("/resources/img/edit.png");
							ImageView view = new ImageView(editIgm);
							Image deleteImg = new Image("/resources/img/trash.png"); 
							ImageView view2 = new ImageView(deleteImg);
							view.setFitHeight(22);
							view.setPreserveRatio(true);
							view2.setFitHeight(22);
							view2.setPreserveRatio(true);
							Button deleteIcon = new Button();
							Button editIcon = new Button();

							editIcon.setGraphic(view); 
							deleteIcon.setGraphic(view2);

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
								topicList1.getItems().clear();
								topicList.getItems().addAll(TopicDAO.getAll());
								topicList.getSelectionModel().select(qst.getTopic());
								Main.getHomeController().showNotification("Los campos esta desactivados, si quieres editar algun campo presione el boton de editar.", "#82DBD8");
					 
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
		enableDisableEditing(false);
	}



	/***
	 * Borrar un apregunta
	 * @param event
	 */
	@FXML
	void delete(ActionEvent event) {
		listPane.toFront();
		if(QuestionDAO.deleteQuestio(idQuestionText.getText())) {
			Main.getHomeController().showNotification("Se ha borrado la pregunta con exito.", "#00FFAB");
			questionsList.getItems().clear();
			questionsList.getItems().addAll(QuestionDAO.obtainFullQuestionList());
		}else {
			Main.getHomeController().showNotification("No se ha borrado la pregunta. comprueba que noha examenes con esta pregunta.", "#FD5D5D");
		}
		enableDisableEditing(false);
	}

	/***
	 * improtar preguntas desde xml
	 * @param event
	 */
	public void importXmlFile(ActionEvent event) {
		FileChooser fx=new FileChooser();
		//		fx.setSelectedExtensionFilter(null);
		File selectedFile=fx.showOpenDialog(null);
		List <Question> questions=ControlUtils.getQuestionFromXml(selectedFile);
		if(questions!=null) {
			if(QuestionDAO.addQuestiosList(questions)) {
				questionsList.getItems().clear();
				questionsList.getItems().addAll(QuestionDAO.obtainFullQuestionList());
				Main.getHomeController().showNotification("Se han insertado las preguntas con exito.", "#00FFAB");
				questionsList.getItems().clear();
				questionsList.getItems().addAll(QuestionDAO.obtainFullQuestionList());
			}else {
				Main.getHomeController().showNotification("Se ha producido un error al insertar las preguntas .", "#FD5D5D");
			}
		}
	}

	/***
	 * gurdar nueva pregunta o los cambios de una existente
	 * @param event
	 */
	@FXML
	void save(ActionEvent event) {

		if(event.getSource()==saveBtn) {
			if(topicList1.getSelectionModel().getSelectedItem()!=null) {
				Question question= new Question(questionText1.getText(), answerText11.getText(), answerText21.getText(), answerText31.getText(), answerText41.getText(), getCorrectIndex(false),topicList1.getSelectionModel().getSelectedItem());
				if(QuestionDAO.addQuestio(question)) {
					Main.getHomeController().showNotification("Se han guardado los cambios con exito.", "#00FFAB");
					questionsList.getItems().clear();
					questionsList.getItems().addAll(QuestionDAO.obtainFullQuestionList());
				}else {
					Main.getHomeController().showNotification("Se ha producido un error al  guardar los cambios.", "#FD5D5D");
				}
				listPane.toFront();
			}else {
				Main.getHomeController().showNotification("Debes seleccionar una tematica ","#82DBD8");
			}
		}else if(event.getSource()==saveEditBtn) {
			Question question= new Question(questionText.getText(), answerText1.getText(), answerText2.getText(), answerText3.getText(), answerText4.getText(), getCorrectIndex(true),topicList.getSelectionModel().getSelectedItem());
			if(topicList.getSelectionModel().getSelectedItem()!=null) {
				question.setId_question(idQuestionText.getText());
				if(QuestionDAO.updateQuestio(question)) {
					Main.getHomeController().showNotification("Se ha creado la pregunta con exito.", "#00FFAB");
					questionsList.getItems().clear();
					questionsList.getItems().addAll(QuestionDAO.obtainFullQuestionList());
				}else {
					Main.getHomeController().showNotification("Se ha producido un error al  guardar la pregunta.", "#FD5D5D");
				}
				listPane.toFront();
				enableDisableEditing(false);
			}else {
				Main.getHomeController().showNotification("Se ha producido un error al  guardar los cambios.", "#FD5D5D");
			}
		}

		questionsList.getItems().clear();
		questionsList.getItems().addAll(QuestionDAO.obtainFullQuestionList());

	}



	/**
	 * mostrar el panel de creacion de preguntas
	 * @param event
	 */
	@FXML 
	void createQuestion(ActionEvent event) {
		createPane.toFront();
		topicList1.getItems().clear();
		topicList1.getItems().addAll(TopicDAO.getAll());
	}


	/***
	 * activar los campos para la edicion de una pregunta
	 * @param event
	 */
	@FXML
	void enableEditing(ActionEvent event) {
		enableDisableEditing(true);

	}
	
	public void enableDisableEditing(boolean enable) {
		questionText.setEditable(enable);
		answerText1.setEditable(enable);
		answerText2.setEditable(enable);
		answerText3.setEditable(enable);
		answerText4.setEditable(enable);

		correctAnswer1.setDisable(!enable);
		correctAnswer2.setDisable(!enable);
		correctAnswer3.setDisable(!enable);
		correctAnswer4.setDisable(!enable);

		topicList.setDisable(!enable);

		saveEditBtn.setVisible(enable);
		cancelEditBtn.setVisible(enable);

	}




	/***
	 * obtener el numero de la respuesta correcta 
	 * @return int : el numero de la respuesta correcta
	 */
	private int getCorrectIndex(boolean callFromEdit) {
		if(callFromEdit) {
			if(correctAnswer1.isSelected()) {
				return 1;				
			}else 	if(correctAnswer2.isSelected()) {
				return 2;
			}else 	if(correctAnswer3.isSelected()) {
				return 3;
			}else {
				return 4;
			}
			
		}else{
			if(correctAnswer11.isSelected()) {
				return 1;				
			}else 	if(correctAnswer21.isSelected()) {
				return 2;
			}else 	if(correctAnswer31.isSelected()) {
				return 3;
			}else {
				return 4;
			}
		}
	}


}
