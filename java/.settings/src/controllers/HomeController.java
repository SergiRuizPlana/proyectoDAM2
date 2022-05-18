package controllers;

 
import java.net.URL;
import java.util.Date;
import java.util.ResourceBundle;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

import javafx.scene.control.Button; 	
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.image.ImageView;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.VBox;
import javafx.scene.text.Text;
import main.Main;
import model.User; 
public class HomeController implements Initializable {

	@FXML
	private BorderPane homeBorderPane;

	@FXML
	private ImageView img;

	@FXML
	private Button currentUserInfo,logOutBtn;

	@FXML
	private AnchorPane messagePane;

	@FXML
	private Text messageText;




	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		img.setVisible(true);
		changeView("Login.fxml",false); 

	}



	/***
	 * Motrar notificaciones en la parte de abajo
	 * @param message
	 * @param color
	 */
	public void showNotification( String message, String color) {
		ExecutorService service = Executors.newFixedThreadPool(4);
		service.submit(new Runnable() {
			public void run() {
				long startTime = System.currentTimeMillis();
				long elapsedTime = 0L; 
				messagePane.setStyle("-fx-background-color:"+color); 
				messageText.setText(message);
				messagePane.setVisible(true);
				while (elapsedTime < 8000) { 
					elapsedTime = (new Date()).getTime() - startTime;
				}
				messagePane.setVisible(false);

				service.shutdownNow();
			}
		});
	}




	/***
	 * Mostrar la vista  que corresponde al usuario despues de  iniciar session 
	 * @param user: El usuario logeado
	 */
	public void loginSucces(User user) { 

		//Establecer el usuario actual en en la classe Main
		Main.getHomeController().setCurrentUserName(user.getFname());

		if(user.getRole().equalsIgnoreCase("TEACHER")) {
			changeView("teacher\\TeacherControlBar.fxml",true);	
			changeView("teacher\\TeacherView.fxml",false);		

		}else if(user.getRole().equalsIgnoreCase("STUDENT")) { 							
			changeView("student\\StudentControlBar.fxml",true);	
			changeView("exams\\StudentExamView.fxml",false);

		}
	}



	/***
	 * Cambira la vista
	 * @param viewName el nombre de la vista
	 * @param isControlTab comprueba si la vista es el tab de control de la parte iquierda
	 */
	public void changeView(String viewName,boolean isControlTab) {
		FXMLLoader fxml=new FXMLLoader(getClass().getClassLoader().getResource("views\\"+viewName));		
		try {
			if(isControlTab) {
				VBox vbox =fxml.load();
				homeBorderPane.setLeft(vbox);
			}else {
				AnchorPane aPane =fxml.load();
				homeBorderPane.setCenter(aPane);			
			}
		} catch (Exception e) { 
			e.printStackTrace();
		}
	}


	/***
	 * Mostrar la informacion de usuario actual
	 */
	@FXML 
	public void showUserInfo() {			
		changeView("UserForm.fxml", false);
		showNotification("Los campos esta desactivados, si quieres editar algun campo presione el boton de editar.", "#82DBD8");
	}


	
	/***
	 * Establece el nombre del usuario actual al boton de informacion
	 * @param name
	 */
	public void setCurrentUserName(String name) {
		currentUserInfo.setText(name);
		currentUserInfo.setVisible(true);
		logOutBtn.setVisible(true);
	}


	/***
	 * Cerra la sesion y muestra la vista del login
	 * @param event
	 */
	@FXML
	public void logOut(ActionEvent event) {
		homeBorderPane.setLeft(null);
		changeView("Login.fxml", false);
	}

	
	//deprecated
	public void redirectHomeView() {
		loginSucces(Main.getCurrentUser());
	}

}
