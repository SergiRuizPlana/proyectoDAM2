package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
 

import model.StatExam;
import model.Topic;

public class StatExamDAO {

	public static boolean insertStatExam(String nif,int hits,int misses,int blank,String idTopic) {
		String sqlComand="insert into statExam (nif,hits,misses,blank,id_topic) values (?,?,?,?,?)";
		
		if(idTopic.equals("")) {
			sqlComand="insert into statExam (nif,hits,misses,blank) values (?,?,?,?)";
		}
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, nif);
			pstm.setInt(2, hits);
			pstm.setInt(3,misses );
			pstm.setInt(4, blank);
			if(!idTopic.equals("")) {
				pstm.setString(5, idTopic);
			}
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

	public static StatExam obtainByNifAndTopic(String nif,String topicId) {
		String sqlComand="select * from statExam where nif=? and id_topic=?";
		StatExam statExam=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, nif);
			pstm.setString(2, topicId);
			ResultSet r = pstm.executeQuery(); 
			if(r.next()) {
				Topic topic=TopicDAO.getById(topicId);
				statExam=new StatExam(r.getString("nif"), r.getInt("hits"), r.getInt("misses"), r.getInt("blank"), r.getDate("stat_date"),topic);
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



	public static List<StatExam> obtainAllStats() {
		List<StatExam>statExams=new ArrayList<>();
		String sqlComand="select s.nif,s.hits,s.misses,s.blank,s.stat_date,u.fname,u.lname ,t.id_topic,t.description  from statExam s left join topic t on t.id_topic=s.id_topic inner join usr u  on u.nif=s.nif";
		StatExam statExam=null;
		try {
			Conection.openConnection();
			Statement stm = Conection.conn.createStatement();
			ResultSet r = stm.executeQuery(sqlComand); 
			while(r.next()) {
				Topic topic= new Topic(r.getString("id_topic"),r.getString("description"));
				statExam=new StatExam(r.getString("nif"), r.getInt("hits"), r.getInt("misses"), r.getInt("blank"), r.getDate("stat_date"),topic);
				statExam.setStudent(r.getString("fname")+" "+r.getString("lname"));
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
	
	public static List<StatExam> obtainAllStatsByUser(String nif) {
		List<StatExam>statExams=new ArrayList<>();
		String sqlComand="select s.nif,s.hits,s.misses,s.blank,s.stat_date ,t.id_topic,t.description  from statExam s left join topic t on t.id_topic=s.id_topic where s.nif=?";
		StatExam statExam=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, nif);
			ResultSet r = pstm.executeQuery(); 
			while(r.next()) {
				Topic topic= new Topic(r.getString("id_topic"),r.getString("description"));
				statExam=new StatExam(r.getString("nif"), r.getInt("hits"), r.getInt("misses"), r.getInt("blank"), r.getDate("stat_date"),topic);
				statExams.add(statExam);
			}
			pstm.close();
			Conection.closeConnection();
			return statExams;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		
		return null;
	}
	
	

	public static Double getStatsbyUser(String nif) {
		String sqlComand="select sum(hits),sum(hits+misses) from statExam where nif=? group by nif";
		int totalQuestions=0,totalCorrect=0;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, nif);
			ResultSet r = pstm.executeQuery(); 
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


	public static Double getStatsbyTopic(String topicId) {
		String sqlComand="select sum(hits),sum(hits+misses) from statExam  where id_topic=? group by id_topic";
		int totalQuestions=1,totalCorrect=0;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, topicId);
			ResultSet r = pstm.executeQuery(); 
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

	public static int getTotalExams(String nif) {
		String sqlComand="select count(nif) from statExam where nif=? ";
		int totalExams=0;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, nif);
			ResultSet r = pstm.executeQuery(); 
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



