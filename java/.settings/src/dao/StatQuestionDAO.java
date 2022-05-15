package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.List;
 

import model.StatQuestion;
import model.Topic;

public class StatQuestionDAO {

	public static StatQuestion obtainById(String id_question,String nif ) {
		String sqlComand="select * from statQuestion where id_question=? and nif=?";
		StatQuestion statQuestion=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, id_question);
			pstm.setString(2,nif);
			ResultSet r = pstm.executeQuery(); 
			if(r.next()) {
				statQuestion=new StatQuestion(r.getString("id_question"),r.getInt("total_hits"), r.getInt("total_misses"), r.getInt("total_blank"));
			}
			pstm.close();
			Conection.closeConnection();
			return statQuestion;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		
		
		return null;
	}
	
	public static List<StatQuestion> obtainByUser(String nif ) {
		String sqlComand="select s.*, t.id_topic,t.description,q.question from statQuestion s inner join question q on q.id_question=s.id_question left join Topic t on t.id_topic=q.id_topic where  nif=?";
		StatQuestion statQuestion=null;
		List<StatQuestion> statQuestions=new ArrayList<>();
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,nif);
			ResultSet r = pstm.executeQuery(); 
			while(r.next()) { 
				Topic topic=new Topic(r.getString("id_topic"),r.getString("description"));
				statQuestion=new StatQuestion(r.getString("id_question"),r.getInt("total_hits"), r.getInt("total_misses"), r.getInt("total_blank"));
				statQuestion.setTopic(topic);
				statQuestion.setQuestion(r.getString("question"));
				statQuestions.add(statQuestion); 
			}
			pstm.close();
			Conection.closeConnection(); 
			return statQuestions;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		
		
		return null;
	}
	
	public static  boolean insertStatQuestion(String id_question,String nif,int hits,int misses,int blank) {
		String sqlComand="insert into statQuestion (id_question,nif,total_hits,total_misses,total_blank) values (?,?,?,?,?)";

		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, id_question);
			pstm.setString(2, nif);
			pstm.setInt(3, hits);
			pstm.setInt(4, misses);
			pstm.setInt(5, blank);
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
	
	public static  boolean updateStatQuestion(String questionId,String nif,int hits,int misses,int blank) {
		String sqlComand="update statQuestion set total_hits+=?, total_misses+=?,total_blank+=? where id_question=? and nif=?";

		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setInt(1, hits);
			pstm.setInt(2, misses);
			pstm.setInt(3, blank);
			pstm.setString(4, questionId);
			pstm.setString(5, nif);
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
	
	
	public static  List<StatQuestion> getAll() {
		String sqlComand="select s.*, t.id_topic,t.description,q.question,u.fname,u.lname from statQuestion  s inner join question q on q.id_question=s.id_question left join Topic t on t.id_topic=q.id_topic  inner join usr u on u.nif=s.nif";
		StatQuestion statQuestion=null;
		List<StatQuestion> statQuestions=new ArrayList<>();
		try {
			Conection.openConnection();
			Statement stm =  Conection.conn.createStatement();
			ResultSet r = stm.executeQuery(sqlComand); 
			while(r.next()) {
				Topic topic=new Topic(r.getString("id_topic"),r.getString("description"));
				statQuestion=new StatQuestion(r.getString("id_question"),r.getInt("total_hits"), r.getInt("total_misses"), r.getInt("total_blank"));
				statQuestion.setTopic(topic);
				statQuestion.setQuestion(r.getString("question"));
				statQuestion.setStudent(r.getString("fname")+" "+r.getString("lname"));
				statQuestions.add(statQuestion);
			}
			stm.close();
			Conection.closeConnection();
			return statQuestions;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		
		
		return null;
	}
	
	
 
	
	
	
	
}
