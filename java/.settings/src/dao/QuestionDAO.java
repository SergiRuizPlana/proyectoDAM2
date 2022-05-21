package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import model.Question;
import model.Topic;

public class QuestionDAO {


	public static boolean addQuestio(Question question) {
		String sqlComand="insert into questions (question,answer1,answer2,answer3,answer4,correctanswer,id_topic) values(?,?,?,?,?,?,?)";
		try {
			Conection.openConnection();
				if(question.getTopic()==null) {
					sqlComand="insert into questions (question,answer1,answer2,answer3,answer4,correctanswer) values(?,?,?,?,?,?)";					
				}
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,question.getQuestion());
			pstm.setString(2,question.getAnswer1());
			pstm.setString(3,question.getAnswer2());
			pstm.setString(4,question.getAnswer3());
			pstm.setString(5,question.getAnswer4());
			pstm.setString(6,question.getCorrectanswer()+"");
			if(question.getTopic()!=null) {
				pstm.setString(7,question.getTopic().getId());
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

	public static boolean addQuestiosList(List <Question> questions) {
		String sqlComand="insert into questions (question,answer1,answer2,answer3,answer4,correctanswer,id_topic) values(?,?,?,?,?,?,?)";
		try {
			Conection.openConnection();
			for (Question question : questions) {
				if(question.getTopic()==null) {
					sqlComand="insert into questions (question,answer1,answer2,answer3,answer4,correctanswer) values(?,?,?,?,?,?)";					
				}
				PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
				pstm.setString(1,question.getQuestion());
				pstm.setString(2,question.getAnswer1());
				pstm.setString(3,question.getAnswer2());
				pstm.setString(4,question.getAnswer3());
				pstm.setString(5,question.getAnswer4());
				pstm.setString(6,question.getCorrectanswer()+"");
				if(question.getTopic()!=null) {
					pstm.setString(7,question.getTopic().getId());
				}
				pstm.executeUpdate();
				pstm.close();			
			}
			Conection.closeConnection();
			return true;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		return false;
	}


	public static boolean updateQuestio(Question question) {
		String sqlComand="update questions set question=?, answer1=?, answer2=?, answer3=?, answer4=?, correctanswer=?,id_topic=? where id_question=?";
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,question.getQuestion());
			pstm.setString(2,question.getAnswer1());
			pstm.setString(3,question.getAnswer2());
			pstm.setString(4,question.getAnswer3());
			pstm.setString(5,question.getAnswer4());
			pstm.setString(6,question.getCorrectanswer()+"");
			pstm.setString(7,question.getTopic().getId());
			pstm.setString(8,question.getId_question()); 
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


	public static boolean deleteQuestio(String idQuestion) {
		String sqlComand="delete from questions where id_question=?";
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,idQuestion);
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

	public static Question obtainById(String id_questio ) {
		String sqlComand="select q.*, description from questions q left join topics t on t.id_topic=q.id_topic where q.id_question=? ";
		Question question=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,id_questio);
			ResultSet r=pstm.executeQuery();
			if(r.next()) {
				Topic topic=new Topic(r.getString("id_topic"), r.getString("description"));
				question=new Question(r.getString("id_question"), r.getString("question"), r.getString("answer1"), r.getString("answer2"), r.getString("answer3"), r.getString("answer4"), r.getInt("correctanswer"), topic);	
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

	
	
	public static List<Question> obtainFullQuestionList() {
		ArrayList<Question> questions=new ArrayList<>();
		String sqlComand="select q.*, description from questions  q left join topics t on t.id_topic=q.id_topic ";
		Question question=null;
		try {
			Conection.openConnection();
			Statement stm = Conection.conn.createStatement();
			ResultSet r = stm.executeQuery(sqlComand); 
			while(r.next()) {
				Topic topic=new Topic(r.getString("id_topic"), r.getString("description"));
				question=new Question(r.getString("id_question"), r.getString("question"), r.getString("answer1"), r.getString("answer2"), r.getString("answer3"), r.getString("answer4"), r.getInt("correctanswer"),topic);	
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


	public static List<Question> obtainLimitedQuestionList(int limit) {
		ArrayList<Question> questions=new ArrayList<>();
		String sqlComand="select top (?) q.*, t.description from questions q left join topics t on t.id_topic=q.id_topic  ORDER BY newid()";
		Question question=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setInt(1, limit);
			ResultSet r=pstm.executeQuery();
			while(r.next()) {
				Topic topic=new Topic(r.getString("id_topic"), r.getString("description"));
				question=new Question(r.getString("id_question"), r.getString("question"), r.getString("answer1"), r.getString("answer2"), r.getString("answer3"), r.getString("answer4"), r.getInt("correctanswer"), topic);	
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

	public static List<Question> obtainLimitedQuestionListByTopic(int limit,String topicId) {
		ArrayList<Question> questions=new ArrayList<>();
		String sqlComand="select top (?) q.*, description from questions  q left join topics t on t.id_topic=q.id_topic where q.id_topic=? ORDER BY newid()";
		Question question=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setInt(1, limit);
			pstm.setString(2,topicId);
			ResultSet r=pstm.executeQuery();
			while(r.next()) {
				Topic topic=new Topic(r.getString("id_topic"), r.getString("description"));
				question=new Question(r.getString("id_question"), r.getString("question"), r.getString("answer1"), r.getString("answer2"), r.getString("answer3"), r.getString("answer4"), r.getInt("correctanswer"), topic);	
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

	public static List<Question> obtainListbyTopic(String idTopic) {
		ArrayList<Question> questions=new ArrayList<>();
		String sqlComand="select q.*, description from questions  q left join topics t on t.id_topic=q.id_topic where q.id_topic=?";
		Question question=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm = Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, idTopic);
			ResultSet r=pstm.executeQuery();
			while(r.next()) {
				Topic topic=new Topic(r.getString("id_topic"), r.getString("description"));
				question=new Question(r.getString("id_question"), r.getString("question"), r.getString("answer1"), r.getString("answer2"), r.getString("answer3"), r.getString("answer4"), r.getInt("correctanswer"), topic);	
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



	public static List<Topic> listOfTopics() {
		List<Topic> topics=new ArrayList<>();
		String sqlComand="select distinct t.id_topic, t.description from questions q inner join topics t on t.id_topic=q.id_topic ";
		Topic topic=null;
		try {
			Conection.openConnection();
			Statement stm = Conection.conn.createStatement();
			ResultSet r = stm.executeQuery(sqlComand); 
			while(r.next()) {
				topic=new Topic(r.getString("id_topic"), r.getString("description"));
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
