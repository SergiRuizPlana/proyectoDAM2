package model;


public class Question {

	private String id_question; 
	private String question;
	private String answer1;
	private String answer2;
	private String answer3;
	private String answer4;
	private int correctanswer; 
	//	private Byte[] img; 
	private String topic;



	public Question(String id_question, String question, String answer1, String answer2, String answer3, String answer4,
			int correctanswer, String topic) {
		super();
		this.id_question = id_question;
		this.question = question;
		this.answer1 = answer1;
		this.answer2 = answer2;
		this.answer3 = answer3;
		this.answer4 = answer4;
		this.correctanswer = correctanswer;
		this.topic = topic;
	}

	public String getId_question() {
		return id_question;
	}

	public void setId_question(String id_question) {
		this.id_question = id_question;
	}

	public String getQuestion() {
		return question;
	}

	public void setQuestion(String question) {
		this.question = question;
	}


	public int getCorrectanswer() {
		return correctanswer;
	}

	public void setCorrectanswer(int correctanswer) {
		this.correctanswer = correctanswer;
	}

	public String getTopic() {
		return topic;
	}

	public void setTopic(String topic) {
		this.topic = topic;
	}

	public String getAnswer1() {
		return answer1;
	}

	public void setAnswer1(String answer1) {
		this.answer1 = answer1;
	}

	public String getAnswer2() {
		return answer2;
	}

	public void setAnswer2(String answer2) {
		this.answer2 = answer2;
	}

	public String getAnswer3() {
		return answer3;
	}

	public void setAnswer3(String answer3) {
		this.answer3 = answer3;
	}

	public String getAnswer4() {
		return answer4;
	}

	public void setAnswer4(String answer4) {
		this.answer4 = answer4;
	}

	



}
