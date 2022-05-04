package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

import model.Topic;

public class TopicDAO {

	public static ArrayList<Topic> getAll(){
		String sqlComand="select * from topic";
		Topic topic=null;
		ArrayList<Topic> topics=new ArrayList<>();
		try {
			Conection.openConnection();
			Statement stm =  Conection.conn.createStatement();
			ResultSet r = stm.executeQuery(sqlComand); 
			while(r.next()) {
				topic=new Topic(r.getString("id_topic"),r.getString("description"));
				topics.add(topic);
			}
			stm.close();
			Conection.closeConnection();
			return topics;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		

		return null;
	}
	
	
	
	public static boolean insertTopic(String description) {
		String sqlComand="insert into topic (description) values (?)";

		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, description);
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
	
	public static boolean updateTopic(String topicId,String description) {
		String sqlComand="update topic set description=? where id_topic=?";

		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, description);
			pstm.setString(2, topicId);
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
	
	public static boolean deleteTopic(String topicId) {
		String sqlComand="delete from topic where id_topic=?";

		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, topicId);
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
	
	
	public static Topic getById(String topicId) {
		String sqlComand="select * from topic where id_topic=?";
		Topic topic=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, topicId);
			ResultSet  r = pstm.executeQuery(); 
			if(r.next()) {
				topic=new Topic(r.getString("id_topic"), r.getString("description"));
			}
			pstm.close();
			Conection.closeConnection();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return topic;
	}
	

}
