package controllers;

import java.net.URL;
import java.util.ResourceBundle;

import dao.TopicDAO; 
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.geometry.Insets;
import javafx.scene.control.Button;
import javafx.scene.control.TableCell;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextField;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.HBox;
import javafx.scene.text.Text;
import javafx.util.Callback;
import main.Main;
import model.Topic; 

public class TopicsController  implements Initializable{

	@FXML
	private TableColumn<Topic, String> description,editCol;

	@FXML
	private TextField editDescription,descriptionText;

	@FXML
	private Text idTopicText;

	@FXML
	private AnchorPane editTopic,topicsList,createPane;

	@FXML
	private Button newTopicBtn,saveBtn,saveEditBtn,cancelEditBtn,cancelBtn;

	@FXML
	private TableView<Topic> topicsTable;


	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		description.setCellValueFactory(new PropertyValueFactory<>("description")); 
		Callback<TableColumn<Topic, String>, TableCell<Topic, String>> cellFoctory = (TableColumn<Topic, String> param) -> {

			final TableCell<Topic, String> cell = new TableCell<Topic, String>() {
				@Override
				public void updateItem(String item, boolean empty) {
					super.updateItem(item, empty);

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
							Topic topic = getTableRow().getItem();       
							if(TopicDAO.deleteTopic(topic.getId())) {
								Main.getHomeController().showNotification("Se ha borrado la tematica con exito.", "#00FFAB");
								topicsList.toFront();
								updateData();
							}
						});

						editIcon.setOnMouseClicked((MouseEvent event) -> {
							editTopic.toFront();
							Topic topic = getTableRow().getItem();       
							idTopicText.setText(topic.getId());
							editDescription.setText(topic.getDescription());
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
		updateData();
	}


	@FXML
	public void cancel(ActionEvent event) {
		topicsList.toFront();
	}


	@FXML
	void click(ActionEvent event) {
		if(event.getSource()==newTopicBtn) {
			createPane.toFront();
		}
	}

	@FXML
	void save(ActionEvent event) {
		if(event.getSource()==saveBtn) {
			if(TopicDAO.insertTopic(descriptionText.getText())) {
				Main.getHomeController().showNotification("Se ha creado la tematica conexito.", "#00FFAB");
				updateData();
				topicsList.toFront();
			}else {
				Main.getHomeController().showNotification("Se ha producido un error al guardar la tematica.", "#FD5D5D");
			}
		}else {
			if(event.getSource()==saveEditBtn) {
				if(TopicDAO.updateTopic(idTopicText.getText(),editDescription.getText())) {
					Main.getHomeController().showNotification("Se han guardado los cambios.", "#00FFAB");
					topicsList.toFront();
					updateData();
				}else {
					Main.getHomeController().showNotification("Se ha producido un error al guardar los cambios.", "#FD5D5D");
				}
			}
		}
	}


	public void updateData() {
		topicsTable.getItems().clear();
		topicsTable.getItems().addAll(TopicDAO.getAll());
	}

}

