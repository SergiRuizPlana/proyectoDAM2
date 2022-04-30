package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

import model.Question;
import model.Topic;

public class QuestionDAO {


	public boolean addQuestio(String[] question) {
		String sqlComand="insert into question ('question','answer1','answer2','answer3','answer4','correctanswer','id_topic') values(?,?,?,?,?,?)";
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,question[0]);
			pstm.setString(2,question[1]);
			pstm.setString(3,question[2]);
			pstm.setString(4,question[3]);
			pstm.setString(5,question[4]);
			pstm.setString(6,question[5]);

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

	public boolean updateQuestio(String[] question) {
		String sqlComand="update question set question=?, answer1=?, answer2=?, answer3=?, answer4=?, correctanswer=?,id_topic=? where id_question=?";
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,question[0]);
			pstm.setString(2,question[1]);
			pstm.setString(3,question[2]);
			pstm.setString(4,question[3]);
			pstm.setString(5,question[4]);
			pstm.setString(6,question[5]);
			pstm.setString(7,question[6]);

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


	public boolean deleteQuestio(String idQuestion) {
		String sqlComand="delete from question where id_question=?";
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(7,idQuestion);
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

	public Question obtainById(String idQuestion) {
		String sqlComand="select *from question where id_question=?";
		Question question=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(7,idQuestion);
			ResultSet r=pstm.executeQuery();
			if(r.next()) {
				question=new Question(r.getString("id_question"), r.getString("question"), r.getString("answer1"), r.getString("answer2"), r.getString("answer3"), r.getString("answer4"), r.getInt("correctanswer"), r.getString("id_topic"));	
			}
			pstm.close();
			Conection.closeConnection();
			return question;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		return null;
	}

	public ArrayList<Question> obtainFullQuestionList() {
		ArrayList<Question> questions=new ArrayList<>();
		String sqlComand="select *from question";
		Question question=null;
		try {
			Conection.openConnection();
			Statement stm = Conection.conn.createStatement();
			ResultSet r = stm.executeQuery(sqlComand); 
			while(r.next()) {
				question=new Question(r.getString("id_question"), r.getString("question"), r.getString("answer1"), r.getString("answer2"), r.getString("answer3"), r.getString("answer4"), r.getInt("correctanswer"), r.getString("id_topic"));	
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


	public ArrayList<Question> obtainLimitedQuestionList(int limit) {
		ArrayList<Question> questions=new ArrayList<>();
		String sqlComand="select top ? * from question ";
		Question question=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setInt(1, limit);
			ResultSet r=pstm.executeQuery();
			while(r.next()) {
				question=new Question(r.getString("id_question"), r.getString("question"), r.getString("answer1"), r.getString("answer2"), r.getString("answer3"), r.getString("answer4"), r.getInt("correctanswer"), r.getString("id_topic"));	
				questions.add(question);
			}
			pstm.close();
			Conection.closeConnection();
			return questions;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		return null;
	}

	public ArrayList<Question> obtainListbyTopic(String idTopic) {
		ArrayList<Question> questions=new ArrayList<>();
		String sqlComand="select * from question where id_topic=?";
		Question question=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, idTopic);
			ResultSet r=pstm.executeQuery();
			while(r.next()) {
				question=new Question(r.getString("id_question"), r.getString("question"), r.getString("answer1"), r.getString("answer2"), r.getString("answer3"), r.getString("answer4"), r.getInt("correctanswer"), r.getString("id_topic"));	
				questions.add(question);
			}
			pstm.close();
			Conection.closeConnection();
			return questions;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		return null;
	}



	public ArrayList<Topic> listOfTopics() {
		ArrayList<Topic> topics=new ArrayList<>();
		String sqlComand="select t.id_tpoic, t.description from question q inner join topic t on t.id_topic=q.id_topic group by q.id_topic";
		Topic topic=null;
		try {
			Conection.openConnection();
			Statement stm = Conection.conn.createStatement();
			ResultSet r = stm.executeQuery(sqlComand); 
			while(r.next()) {
				topic=new Topic(r.getString("t.id_tpoic"), r.getString("t.description"));
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




}
