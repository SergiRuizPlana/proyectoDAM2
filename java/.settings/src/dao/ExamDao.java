package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

import model.Exam;
import model.Question;

public class ExamDao {


	public static boolean insertExam(String topicId,String description) {
		String sqlComand="insert into exam (id_topic,description) values(?,?)";

		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, topicId);
			pstm.setString(2,description);
			pstm.executeUpdate(); 
			pstm.close();
			Conection.closeConnection();
			return true;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		

		return false;
	}


	public static boolean UpdateExam(String examId,String topicId,String description) {
		String sqlComand="update exam set id_topic=?,description=?  where id_exam=?";

		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, topicId);
			pstm.setString(2,description);
			pstm.setString(3,examId);
			pstm.executeUpdate(); 
			pstm.close();
			Conection.closeConnection();
			return true;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		

		return false;
	}


	public static boolean deleteExam(String examId) {
		String sqlComand="delete from exam where id_exam=?";
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, examId);
			pstm.executeUpdate(); 
			pstm.close();
			Conection.closeConnection();
			return true;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		

		return false;
	}


	public static boolean insertQuestions(String examId,String questionId) {
		String sqlComand="insert into examQuestion (id_exam,id_question) values(?,?)";

		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, examId);
			pstm.setString(2,questionId);
			pstm.executeUpdate(sqlComand); 
			pstm.close();
			Conection.closeConnection();
			return true;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		

		return false;
	}
	
	public static ArrayList<Exam> getAll(){
		String sqlComand="select e.id_exam,e.id_topic,e.description,count(eq.id_exam) as num_questions from exam e left join examQuestion eq on eq.id_exam=e.id_exam group by e.id_exam,e.id_topic,e.description";
		Exam exam=null;
		ArrayList<Exam> exams=new ArrayList<>();
		try {
			Conection.openConnection();
			Statement stm =  Conection.conn.createStatement();
			ResultSet r = stm.executeQuery(sqlComand); 
			while(r.next()) {
				exam=new Exam(r.getString("id_exam"),r.getString("id_topic"),r.getString("description"),r.getInt("num_questions"));
				exams.add(exam);
			}
			stm.close();
			Conection.closeConnection();
			return exams;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		

		return null;
	}
	
	
	
	
	public static ArrayList<Exam> getByTopic(String topicId){
		String sqlComand="select e.id_exam,e.id_topic,e.description,count(eq.id_exam) as num_questions from exam e left join examQuestion eq on eq.id_exam=e.id_exam where id_topic=? group by e.id_exam,e.id_topic,e.description";
		Exam exam=null;
		ArrayList<Exam> exams=new ArrayList<>();
		try {
			Conection.openConnection();
			PreparedStatement stm =  Conection.conn.prepareStatement(sqlComand);
			stm.setString(1, topicId);
			ResultSet r = stm.executeQuery(); 
			while(r.next()) {
				exam=new Exam(r.getString("id_exam"),r.getString("id_topic"),r.getString("description"),r.getInt("num_questions"));
				exams.add(exam);
			}
			stm.close();
			Conection.closeConnection();
			return exams;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		

		return null;
	}
	
	
	
	
	
	public static Exam getById(String examId){
		String sqlComand="select e.id_exam,e.id_topic,e.description,count(eq.id_exam) as num_questions from exam e left join examQuestion eq on eq.id_exam=e.id_exam where e.id_exam=? group by e.id_exam,e.id_topic,e.description";
		Exam exam=null;
		try {
			Conection.openConnection();
			PreparedStatement stm =  Conection.conn.prepareStatement(sqlComand);
			stm.setString(1, examId);
			ResultSet r = stm.executeQuery(); 
			if(r.next()) {
				exam=new Exam(r.getString("id_exam"),r.getString("id_topic"),r.getString("description"),r.getInt("num_questions"));
			}
			stm.close();
			Conection.closeConnection();
			return exam;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		

		return null;
	}
	
	
	
	
	public static ArrayList<Question> getQuestions(String examId){
		String sqlComand="select * from  examQuestion where id_exam=?";
		Question question=null;
		ArrayList<Question> questions=new ArrayList<>();
		try {
			Conection.openConnection();
			Statement stm =  Conection.conn.createStatement();
			ResultSet r = stm.executeQuery(sqlComand); 
			while(r.next()) {
				question=new Question(r.getString("id_question"),r.getString("question"),r.getString("answer1"),r.getString("answer2"),r.getString("answer3"),r.getString("answer4"),r.getInt("correctanswer"),r.getString("id_topic"));
				questions.add(question);
			}
			stm.close();
			Conection.closeConnection();
			return questions;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		

		return null;
	}
	
	
	

}
