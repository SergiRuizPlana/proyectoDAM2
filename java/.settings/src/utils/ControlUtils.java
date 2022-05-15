package utils;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.xml.sax.SAXException;

import dao.TopicDAO;
import javafx.scene.control.TextField;
import model.Question;
import model.Topic;

public class ControlUtils {


	public static void resetTextBox(TextField[] texts) {
		for (TextField textField : texts) {
			textField.setText("");
		}
	}

	public static List<Question>  getQuestionFromXml(File file) {
 
		List <Question>questions=new ArrayList<>();
		try {
			DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
			DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
			Document doc = dBuilder.parse(file);

			doc.getDocumentElement().normalize();
			
			String idTopic= ((Element) doc.getElementsByTagName("questions").item(0)).getAttribute("topicId");
			Topic topic=TopicDAO.getById(idTopic);
			NodeList nList = doc.getElementsByTagName("question");

			for(int temp = 0; temp < nList.getLength(); temp++) {

				String questionText="",correctAnswer="",answer1="",answer2="",answer3="",answer4="";
				Node nNode = nList.item(temp);

				if(nNode.getNodeType() == Node.ELEMENT_NODE) {
					Element eElement = (Element) nNode; 
					questionText = eElement.getElementsByTagName("questionText").item(0).getTextContent().trim();
					
					Node answers = eElement.getElementsByTagName("answers").item(0);
					Element eAnswers = (Element) answers;
					
					correctAnswer=eAnswers.getAttribute("correctAnswer").trim();
					try {
						answer1 =eElement.getElementsByTagName("answer1").item(0).getTextContent().trim();
						answer2 =eElement.getElementsByTagName("answer2").item(0).getTextContent().trim();
						answer3 =eElement.getElementsByTagName("answer3").item(0).getTextContent().trim();
						answer4 =eElement.getElementsByTagName("answer3").item(0).getTextContent().trim();
					}catch (Exception e) {
					}
					
					questions.add(new Question(questionText, answer1, answer2, answer3,answer4, Integer.parseInt(correctAnswer), topic));
				}
				
			}
			
			return questions;

		} catch (IOException | ParserConfigurationException | SAXException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
	}
}
