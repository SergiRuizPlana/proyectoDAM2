package controllers;

import java.net.URL;
import java.util.ResourceBundle;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.geometry.Insets;
import javafx.scene.control.RadioButton;
import javafx.scene.control.ScrollPane;
import javafx.scene.layout.Pane;
import javafx.scene.layout.VBox;
import javafx.scene.text.Text;

public class ExamController  implements Initializable{
	
    @FXML
    private VBox vb;

    @FXML
    private ScrollPane scPane;
    
    @FXML
    private Text questionText;

    @FXML
    private RadioButton response;
	
	

	@SuppressWarnings("static-access")
	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		// TODO Auto-generated method stub
		
//		System.out.println("asd"); 
		for(int i=0;i<10;i++) {
			VBox vb2 = new VBox ();
			vb.setMargin(vb2, new Insets(0, 0, 10, 0));
			vb2.setMinWidth(vb.getWidth());
			Text tx=new Text();
			tx.setText("Quetsion"+i);
			vb2.getChildren().add(tx);
			
			for(int j=0;j<4;j++) {
				RadioButton rd = new RadioButton();
				rd.setText("radioButttom"+j);				
				vb2.setMargin(rd, new Insets(0, 0, 5, 0));
				vb2.getChildren().add( rd);
			}
			vb.getChildren().add(vb2);
		}
		
		
	}
	@FXML
	public void click2(ActionEvent e) {
		System.out.println("asd"); 
	}

}
