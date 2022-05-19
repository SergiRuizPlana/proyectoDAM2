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
		String sqlComand="insert into statsExams (nif,hits,misses,blank,id_topic) values (?,?,?,?,?)";
		if(idTopic.equals("")) {
			sqlComand="insert into statsExams (nif,hits,misses,blank) values (?,?,?,?)";
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

	public static List<StatExam> obtainByNameAndTopic(String name,String topicId) {
		String sqlComand="select * from statsExams s left join topics t on t.id_topic=s.id_topic inner join usrs u on u.nif=s.nif  where CONCAT(fname,CONCAT(' ',lname)) like ?  and t.id_topic=?";
		StatExam statExam=null;
		List<StatExam>statExams=new ArrayList<>();
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,"%"+name+"%");
			pstm.setString(2, topicId);
			ResultSet r = pstm.executeQuery(); 
			if(r.next()) {
				Topic topic= new Topic(r.getString("id_topic"),r.getString("description"));
				statExam=new StatExam(r.getString("nif"), r.getInt("hits"), r.getInt("misses"), r.getInt("blank"), r.getDate("stat_date"),topic);
				statExam.setStudent(r.getString("fname")+" "+r.getString("lname"));
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


	
	public static List<StatExam> obtainAllStats() {
		List<StatExam>statExams=new ArrayList<>();
		String sqlComand="select s.nif,s.hits,s.misses,s.blank,s.stat_date,u.fname,u.lname ,t.id_topic,t.description  from statsExams s left join topics t on t.id_topic=s.id_topic inner join usrs u  on u.nif=s.nif";
		StatExam statExam=null;
		try {
			Conection.openConnection();
			Statement stm = Conection.conn.createStatement();
			ResultSet r = stm.executeQuery(sqlComand); 
			while(r.next()) {
				Topic topic= new Topic(r.getString("id_topic"),r.getString("description"));
				statExam=new StatExam(r.getString("nif"), r.getInt("hits"), r.getInt("misses"), r.getInt("blank"), r.getDate("stat_date"),topic);
				statExam.setStudent(r.getString("fname")+" "+r.getString("lname"));
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
	public static List<StatExam> obtainAllStatsByNif(String nif) {
		List<StatExam>statExams=new ArrayList<>(); 
		String sqlComand="select * from statsExams s inner join usrs u on u.nif=s.nif left join topics t on t.id_topic=s.id_topic where  u.nif=? ";
		StatExam statExam=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,nif);
			ResultSet r = pstm.executeQuery(); 
			while(r.next()) {
				Topic topic= new Topic(r.getString("id_topic"),r.getString("description"));
				statExam=new StatExam(r.getString("nif"), r.getInt("hits"), r.getInt("misses"), r.getInt("blank"), r.getDate("stat_date"),topic);
				statExam.setStudent(r.getString("fname")+" "+r.getString("lname"));
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
	
	public static List<StatExam> obtainAllStatsByUser(String name) {
		List<StatExam>statExams=new ArrayList<>(); 
		String sqlComand="select * from statsExams s inner join usrs u on u.nif=s.nif left join topics t on t.id_topic=s.id_topic where CONCAT(fname,CONCAT(' ',lname)) like ? ";
		StatExam statExam=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,"%"+name+"%");
			ResultSet r = pstm.executeQuery(); 
			while(r.next()) {
				Topic topic= new Topic(r.getString("id_topic"),r.getString("description"));
				statExam=new StatExam(r.getString("nif"), r.getInt("hits"), r.getInt("misses"), r.getInt("blank"), r.getDate("stat_date"),topic);
				statExam.setStudent(r.getString("fname")+" "+r.getString("lname"));
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
	
	public static List<StatExam> obtainAllStatsByTopic(Topic topic) {
		List<StatExam>statExams=new ArrayList<>(); 
		String sqlComand="select * from statsExams s inner join usrs u on u.nif=s.nif  left join topics t on t.id_topic=s.id_topic where  t.id_topic=?";
		StatExam statExam=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,topic.getId());
			ResultSet r = pstm.executeQuery(); 
			while(r.next()) {
				statExam=new StatExam(r.getString("nif"), r.getInt("hits"), r.getInt("misses"), r.getInt("blank"), r.getDate("stat_date"),topic);
				statExam.setStudent(r.getString("fname")+" "+r.getString("lname"));
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
	
	public static List<StatExam> obtainLastFive(String nif) {
		List<StatExam>statExams=new ArrayList<>();
		String sqlComand="select top 5 s.nif,s.hits,s.misses,s.blank,s.stat_date ,t.id_topic,t.description  from statsExams s left join topics t on t.id_topic=s.id_topic where s.nif=? order by s.stat_date desc";
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
		String sqlComand="select sum(hits),sum(hits+misses) from statsExams where nif=? group by nif";
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
		String sqlComand="select sum(hits),sum(hits+misses) from statsExams  where id_topic=? group by id_topic";
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
		String sqlComand="select count(nif) from statsExams where nif=? ";
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



