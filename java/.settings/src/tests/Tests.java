package tests;
 
import static org.junit.jupiter.api.Assertions.*;

import org.junit.AfterClass;
import org.junit.jupiter.api.MethodOrderer.OrderAnnotation;
import org.junit.jupiter.api.Order;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.TestMethodOrder;

import dao.QuestionDAO;
import dao.StatExamDAO;
import dao.StatQuestionDAO;
import dao.UserDAO;
import model.Question;
import model.StatExam;
import model.User;


@TestMethodOrder(OrderAnnotation.class)
class Tests {

	private static StringBuilder output = new StringBuilder("");
	
	//insert user an check if exist and update it
	@Test
	@Order(1)
	void insertAndUpdateUser() {
		User usr=new User("C12345678","fname", "lname","userName", "adress", "city","2000","964454", "psswd", "email.com", "STUDENT");
		assert UserDAO.insertUser(usr);

		assertTrue(UserDAO.checkCredentials("userName", "psswd")!=null);

		String[] userInfo = {"C12345678","newFname", "lname", "newAdress", "city","2000","964454", "email.com", "STUDENT"};

		assertTrue(UserDAO.updateUser(userInfo, "C12345678"));

		assertTrue(UserDAO.searchByNif("C12345678").get(0).getFname().equals("newFname"));
		
		output.append("1");
	}


	//insert question 
	@Test
	@Order(2)
	void insertQuestion() {
		Question q = new Question("QuestionTest from junit", "answer1", "answer2", "answer3","answer4", 1, null);
		assertTrue( QuestionDAO.addQuestio(q));
		
		output.append("2");
	}
	
	
	// insert an get StatQuestion 
	@Test
	@Order(3)
	void insertAndGetStatQuestion() {
		Question q =QuestionDAO.obtainLimitedQuestionList(1).get(0);
		assertTrue(StatQuestionDAO.insertStatQuestion(q.getId_question(), "C12345678", 0, 1, 0));

		assertTrue(StatQuestionDAO.obtainByUser("C12345678").get(0).getTotal_misses()==1);
		
		output.append("3");
	}
	
	
	
	//get question an delete it

	@Test
	@Order(4)
	void getAndDeleteQuestion() {
		Question q =QuestionDAO.obtainLimitedQuestionList(1).get(0);
		assertTrue(q!=null);
		assertTrue(QuestionDAO.deleteQuestio(q.getId_question()));
		
		 output.append("4");
	}

	
	// insert statExam and check if exists
	@Test
	@Order(5)
	void insertStatExam() {
		assertTrue(StatExamDAO.insertStatExam("C12345678", 10, 10, 10,""));
		
		StatExam statExam = StatExamDAO.obtainAllStatsByNif("C12345678").get(0);
		assertTrue(statExam!=null && statExam.getHits()==10);
		
		output.append("5");
		
	}
	
	
	// delete user
	@Test
	@AfterClass
	void deleteUser() {
		assertTrue(UserDAO.deleteUser("C12345678"));
		
		assertTrue(UserDAO.deleteUser("C12345678"));
		output.append("6");
		
		//para comprobar si los tests se han ejecutado en el orsen correcto
		  assertEquals(output.toString(), "123456");
	}

}
