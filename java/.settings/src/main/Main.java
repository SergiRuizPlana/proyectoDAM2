package main;
 

import java.io.File;

import controllers.HomeController; 
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.image.Image;
import javafx.stage.Stage; 
import model.User; 

public class Main  extends Application{

	public static  User currentUser;
	private static HomeController homeC; 

	
	
	public static void main(String[] args) {
		launch(args);
	}

	@Override
	public void start(Stage primaryStage) throws Exception {  
		FXMLLoader loader = new FXMLLoader(getClass().getClassLoader().getResource("views"+File.separator+"Home.fxml"));
		Parent root = loader.load();
		homeC=loader.getController();
		String css = getClass().getClassLoader().getResource("styles"+File.separator+"styles.css").toExternalForm(); 
		Scene scene= new Scene(root);
		scene.getStylesheets().add(css);
		primaryStage.getIcons().add(new Image(File.separator+"resources"+File.separator+"img"+File.separator+"logo2.png"));
		primaryStage.setMaximized(true);
		primaryStage.setScene(scene);
		primaryStage.show();
	}


	public static HomeController getHomeController() {
		return homeC;
	}

	public static User getCurrentUser() {
		return currentUser;
	}

	public static void setCurrentUser(User currentUser) {
		Main.currentUser = currentUser;
	}
	
	
	
	
}
