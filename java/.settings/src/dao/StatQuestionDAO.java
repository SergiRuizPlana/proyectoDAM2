package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

import model.StatQuestion;

public class StatQuestionDAO {

	public static StatQuestion obtainById(String id_question) {
		String sqlComand="select * from statQuestion where id_question=?";
		StatQuestion statQuestion=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, id_question);
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
	
	public static  boolean insertStatQuestion(String id_question) {
		String sqlComand="insert into statQuestion (id_question,total_hits,total_misses,total_blank) values (?,0,0,0)";

		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, id_question);
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
	
	public static  boolean updateStatQuestion(String questionId,int hits,int misses,int blank) {
		String sqlComand="update statQuestion set total_hits+=?, total_misses+=?,total_blank+=? where id_question=?";

		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setInt(1, hits);
			pstm.setInt(2, misses);
			pstm.setInt(3, blank);
			pstm.setString(4, questionId);
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
	
	
	public static  ArrayList<StatQuestion> getAll() {
		String sqlComand="select * from statQuestion";
		StatQuestion statQuestion=null;
		ArrayList<StatQuestion> statQuestions=new ArrayList<>();
		try {
			Conection.openConnection();
			Statement stm =  Conection.conn.createStatement();
			ResultSet r = stm.executeQuery(sqlComand); 
			while(r.next()) {
				statQuestion=new StatQuestion(r.getString("id_question"),r.getInt("total_hits"), r.getInt("total_misses"), r.getInt("total_blank"));
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
