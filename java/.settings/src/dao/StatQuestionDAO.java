package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

import model.StatQuestion;

public class StatQuestionDAO {

	public StatQuestion obtainById(String id_question) {
		String sqlComand="select * from statQuestions where id_exam=? and nif=?";
		StatQuestion statQuestion=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, id_question);
			ResultSet r = pstm.executeQuery(sqlComand); 
			if(r.next()) {
				statQuestion=new StatQuestion(r.getString("id_exam"),r.getInt("total_hits"), r.getInt("total_misses"), r.getInt("total_blank"));
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
	
	public boolean insertStatQuestion(String id_question) {
		String sqlComand="insert into statQuestions ('id_questio','total_hits','total_misses','total_blank') values (?,0,0,0)";

		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, id_question);
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
	
	public boolean updateStatQuestion(int hits,int misses,int blank) {
		String sqlComand="update statQuestions set total_hits+=?, total_miss+=?,total_blank+=? ";

		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setInt(1, hits);
			pstm.setInt(2, misses);
			pstm.setInt(3, blank);
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
	
	
	public ArrayList<StatQuestion> getAll() {
		String sqlComand="select * from statQuestions";
		StatQuestion statQuestion=null;
		ArrayList<StatQuestion> statQuestions=new ArrayList<>();
		try {
			Conection.openConnection();
			Statement stm =  Conection.conn.createStatement();
			ResultSet r = stm.executeQuery(sqlComand); 
			while(r.next()) {
				statQuestion=new StatQuestion(r.getString("id_exam"),r.getInt("total_hits"), r.getInt("total_misses"), r.getInt("total_blank"));
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
