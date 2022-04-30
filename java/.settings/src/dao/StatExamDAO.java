package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

import model.StatExam;

public class StatExamDAO {


	public StatExam obtainByNifAndExam(String nif,String exam) {
		String sqlComand="select * from statExam where id_exam=? and nif=?";
		StatExam statExam=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, exam);
			pstm.setString(2, nif);
			ResultSet r = pstm.executeQuery(sqlComand); 
			if(r.next()) {
				statExam=new StatExam(r.getString("id_exam"),r.getString("nif"), r.getInt("hits"), r.getInt("misses"), r.getInt("blank"), r.getDate("stat_date"));
			}
			pstm.close();
			Conection.closeConnection();
			return statExam;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		
		return null;
	}



	public ArrayList<StatExam> obtainAllStats() {
		ArrayList<StatExam>statExams=new ArrayList<>();
		String sqlComand="select * from statExam";
		StatExam statExam=null;
		try {
			Conection.openConnection();
			Statement stm = Conection.conn.createStatement();
			ResultSet r = stm.executeQuery(sqlComand); 
			while(r.next()) {
				statExam=new StatExam(r.getString("id_exam"),r.getString("nif"), r.getInt("hits"), r.getInt("misses"), r.getInt("blank"), r.getDate("stat_date"));
				statExams.add(statExam);
			}
			stm.close();
			Conection.closeConnection();
			return statExams;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		
		return null;
	}

	public Double getStatsbyUser(String userId) {
		String sqlComand="select sum(hits),sum(hits+misses) from statExam where nif=? group by nif";
		int totalQuestions=0,totalCorrect=0;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, userId);
			ResultSet r = pstm.executeQuery(sqlComand); 
			if(r.next()) {
				totalCorrect=r.getInt(1);
				totalQuestions=r.getInt(2);
			}
			pstm.close();
			Conection.closeConnection();
			return (totalCorrect*100.0)/totalQuestions;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		
		return 0.0;
	}


	public Double getStatsbyTopic(String topicId) {
		String sqlComand="select sum(hits),sum(hits+misses) from statExam where id_topic=? group by id_topic";
		int totalQuestions=0,totalCorrect=0;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, topicId);
			ResultSet r = pstm.executeQuery(sqlComand); 
			if(r.next()) {
				totalCorrect=r.getInt(1);
				totalQuestions=r.getInt(2);
			}
			pstm.close();
			Conection.closeConnection();
			return (totalCorrect*100.0)/totalQuestions;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		
		return 0.0;
	}

	public int getTotalExams(String userId) {
		String sqlComand="select count(nif) from statExam where nif=? ";
		int totalExams=0;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, userId);
			ResultSet r = pstm.executeQuery(sqlComand); 
			if(r.next()) {
				totalExams=r.getInt(1);
			}
			pstm.close();
			Conection.closeConnection();
			return totalExams;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		
		return 0;
	}


}



