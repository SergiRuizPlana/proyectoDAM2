package test;

import controllers.HomeController;
import controllers.LoginController;
import dao.ExamDao;
import dao.QuestionDAO;
import dao.StatExamDAO;
import dao.StatQuestionDAO;
import dao.TopicDAO;
import dao.UserDAO;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;
import model.Exam;
import model.Question;
import model.StatQuestion;

public class Test  extends Application{

	private static HomeController homeC;
	private static LoginController loginC;
	public static Stage stage;
	public static void main(String[] args) {
		launch(args);

	}

	@Override
	public void start(Stage primaryStage) throws Exception {  
		stage=primaryStage;
		FXMLLoader loader = new FXMLLoader(getClass().getClassLoader().getResource("views\\Home.fxml"));
		Parent root = loader.load();
		homeC=loader.getController();
		primaryStage.setScene(new Scene(root));
		primaryStage.show();
	}
	
	
	public static HomeController getHomeController() {
		return homeC;
	}
	
	public static Stage getStage() {
		return stage;
	}
}
