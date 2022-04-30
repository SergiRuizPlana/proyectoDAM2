package test;

import controllers.HomeController;
import controllers.LoginController;
import dao.ExamDao;
import dao.TopicDAO;
import dao.UserDAO;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;
import model.Exam;

public class Test  extends Application{
	
	private static HomeController homeC;
	private LoginController loginC;
    public static void main(String[] args) {
//	 launch(args);
    	
    	System.out.println(ExamDao.getAll());
    	System.out.println(ExamDao.getByTopic("661DA9B5-D306-4804-9900-66A9653614EB"));
    	System.out.println(ExamDao.getById("3FE2D8E4-8ED5-4EB8-8B77-C3CB7AD07221"));
}
    
    
    
    
 
 @Override
	public void start(Stage primaryStage) throws Exception {
		// TODO Auto-generated method stub
	 FXMLLoader loader = new FXMLLoader(getClass().getClassLoader().getResource("views\\Home.fxml"));
	 		Parent root = loader.load();
	 		homeC=loader.getController();
	 		homeC.setStage(primaryStage);
	 		homeC.setParent(root);
	 		primaryStage.setScene(new Scene(root));
	 		primaryStage.show();
	}
 
 
 
 public static HomeController getHomeController() {
	 return homeC;
 }
}
