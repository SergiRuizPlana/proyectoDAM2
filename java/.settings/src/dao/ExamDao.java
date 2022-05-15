package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import model.Exam;
import model.Question;
import model.Topic;

public class ExamDao {


	public static boolean insertExam(Exam exam) {
		String sqlComand="insert into exam (id_topic,description) values(?,?)";

		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, exam.getTopic().getId());
			pstm.setString(2,exam.getDescription());
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


	public static boolean UpdateExam(Exam exam) {
		String sqlComand="update exam set id_topic=?,description=?  where id_exam=?";

		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, exam.getTopic().getId());
			pstm.setString(2,exam.getDescription());
			pstm.setString(3,exam.getId());
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


	public static boolean deleteExam(Exam exam) {
		String sqlComand="delete from exam where id_exam=?";
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, exam.getId());
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


	public static boolean insertQuestions(Exam exam,Question question) {
		String sqlComand="insert into examQuestion (id_exam,id_question) values(?,?)";

		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, exam.getId());
			pstm.setString(2,question.getId_question());
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
	
	public static ArrayList<Exam> getAll(){
		String sqlComand="select e.id_exam,e.id_topic,e.description,count(eq.id_exam) as num_questions from exam e left join examQuestion eq on eq.id_exam=e.id_exam group by e.id_exam,e.id_topic,e.description";
		String sqlComand2="select id_question from examQuestion  where id_exam=? ";
		
		Exam exam=null;
		ArrayList<Exam> exams=new ArrayList<>();
		try {
			Conection.openConnection();
			Statement stm =  Conection.conn.createStatement();
			ResultSet r = stm.executeQuery(sqlComand); 
			PreparedStatement pstm;
			while(r.next()) {
				exam=new Exam(r.getString("id_exam"),r.getString("description"));
				pstm=Conection.conn.prepareStatement(sqlComand2);
				pstm.setString(1, exam.getId());
				ResultSet r2 = pstm.executeQuery(); 
				while(r2.next()) {
					exam.addQuestions(QuestionDAO.obtainById(r2.getString(1)));
				}
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
	
	
	
	
	public static List<Exam> getByTopic(String topicId){
		String sqlComand="select e.id_exam,e.id_topic,e.description,count(eq.id_exam) as num_questions from exam e left join examQuestion eq on eq.id_exam=e.id_exam "
				+ "left join topic t on e.id_topic=t.id_topic where id_topic=? group by e.id_exam,e.id_topic, e.description ";
		Exam exam=null;
		List<Exam> exams=new ArrayList<>();
		try {
			Conection.openConnection();
			PreparedStatement stm =  Conection.conn.prepareStatement(sqlComand);
			stm.setString(1, topicId);
			ResultSet r = stm.executeQuery(); 
			while(r.next()) {
				Topic topic =new Topic(r.getString("id_topic"),r.getString("topicDescription"));
				exam=new Exam(r.getString("id_exam"),r.getString("description")); 
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
				exam=new Exam(r.getString("id_exam"),r.getString("description"));
				Topic topic = TopicDAO.getById(r.getString("id_topic"));
				exam.setTopic(topic);
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
	
	
	
	
	public static List<Question> getQuestions(String examId){
		String sqlComand="select q.*, t.description from  examQuestion eq inner join question q on q.id_question=eq.id_question "
				+ "left join topic t on t.id_topic=q.id_topic where id_exam=?";
		Question question=null;
		List<Question> questions=new ArrayList<>();
		try {
			Conection.openConnection();
			PreparedStatement stm =  Conection.conn.prepareStatement(sqlComand);
			stm.setString(1, examId);
			ResultSet r = stm.executeQuery(); 
			while(r.next()) {
				Topic topic=new Topic(r.getString("id_topic"),r.getString("description" ));
				question=new Question(r.getString("id_question"),r.getString("question"),r.getString("answer1"),r.getString("answer2"),r.getString("answer3"),r.getString("answer4"),r.getInt("correctanswer"),topic);
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
