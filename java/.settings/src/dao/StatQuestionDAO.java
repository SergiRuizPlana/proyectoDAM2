package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
 

import model.StatQuestion;
import model.Topic;

public class StatQuestionDAO {

	public static List<StatQuestion> obtainByTopicAndName(Topic topic,String name ) {
		String sqlComand="select * from statsQuestions s inner join usrs u on u.nif=s.nif inner join questions q on q.id_question=s.id_question left join topics t on t.id_topic=q.id_topic where q.id_topic=? and CONCAT(fname,CONCAT(' ',lname)) like ?";
		StatQuestion statQuestion=null;
		List<StatQuestion> statQuestions=new ArrayList<>();
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, topic.getId());
			pstm.setString(2,"%"+name+"%");
			ResultSet r = pstm.executeQuery(); 
			while(r.next()) {
				statQuestion=new StatQuestion(r.getString("id_question"),r.getString("question"),r.getInt("total_hits"), r.getInt("total_misses"), r.getInt("total_blank"));
				statQuestion.setTopic(topic);
				statQuestion.setStudent(r.getString("fname")+" "+r.getString("lname"));
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
	
	public static List<StatQuestion> obtainByName(String name ) {
		String sqlComand="select * from statsQuestions s inner join usrs u on u.nif=s.nif  inner join questions q on q.id_question=s.id_question left join topics t on t.id_topic=q.id_topic where  CONCAT(fname,CONCAT(' ',lname)) like ?";
		StatQuestion statQuestion=null;
		List<StatQuestion> statQuestions=new ArrayList<>();
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,"%"+name+"%");
			ResultSet r = pstm.executeQuery(); 
			while(r.next()) {
				statQuestion=new StatQuestion(r.getString("id_question"),r.getString("question"),r.getInt("total_hits"), r.getInt("total_misses"), r.getInt("total_blank"));
				Topic topic=new Topic(r.getString("id_topic"),r.getString("description"));
				statQuestion.setTopic(topic);
				statQuestion.setStudent(r.getString("fname")+" "+r.getString("lname"));
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
	
	public static List<StatQuestion> obtainByTopic(Topic topic) {
		String sqlComand="select * from statsQuestions s  inner join usrs u on u.nif=s.nif inner join questions q on q.id_question=s.id_question left join topics t on t.id_topic=q.id_topic  where t.id_topic=? ";
		StatQuestion statQuestion=null;
		List<StatQuestion> statQuestions=new ArrayList<>();
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, topic.getId()); 
			ResultSet r = pstm.executeQuery(); 
			while(r.next()) {
				statQuestion=new StatQuestion(r.getString("id_question"),r.getString("question"),r.getInt("total_hits"), r.getInt("total_misses"), r.getInt("total_blank"));
				statQuestion.setTopic(topic);
				statQuestion.setStudent(r.getString("fname")+" "+r.getString("lname"));
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
	
	public static int getTotalQuestions(String nif ) {
		String sqlComand="select count(id_question) as total from statsQuestions where nif=?";
 
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,nif);
			ResultSet r = pstm.executeQuery(); 
			if(r.next()) {
				return  r.getInt("total");
			}
			pstm.close();
			Conection.closeConnection();

		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		
		
		return 0;
	}
	
	public static List<StatQuestion> obtainByUser(String nif ) {
		String sqlComand="select s.*, t.id_topic,t.description,q.question from statsQuestions s inner join questions q on q.id_question=s.id_question left join topics t on t.id_topic=q.id_topic where  nif=?";
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
		String sqlComand="insert into statsQuestions (id_question,nif,total_hits,total_misses,total_blank) values (?,?,?,?,?)";

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
		String sqlComand="select count(nif) from statsQuestions where id_question=? and nif=?";

		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, questionId);
			pstm.setString(2, nif);
			ResultSet r = pstm.executeQuery();
			if(r.next() && r.getInt(1)>0) {
				sqlComand="update statsQuestions set total_hits+=?, total_misses+=?,total_blank+=? where id_question=? and nif=?";
				pstm = Conection.conn.prepareStatement(sqlComand);
				pstm.setInt(1, hits);
				pstm.setInt(2, misses);
				pstm.setInt(3, blank);
				pstm.setString(4, questionId);
				pstm.setString(5, nif);
				pstm.executeUpdate(); 
			}
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
		String sqlComand="select s.*, t.id_topic,t.description,q.question,u.fname,u.lname from statsQuestions  s inner join questions q on q.id_question=s.id_question left join topics t on t.id_topic=q.id_topic  inner join usrs u on u.nif=s.nif";
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
