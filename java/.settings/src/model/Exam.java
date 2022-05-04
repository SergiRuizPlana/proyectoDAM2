package model;

import java.util.ArrayList;
import java.util.List;

public class Exam {
	
	private String id;
	private Topic topic;
	private String description;
	private List<Question> questions=new ArrayList<>();
	
	public Exam(String id, String Topic, String description) {
		super();
		this.id = id;
		this.topic = topic;
		this.description = description;
	}
	
	public Exam(String id, String description) {
		super();
		this.id = id;
		this.description = description;
	}
	
	public Exam(Topic topic, String description) {
		super();
		this.topic = topic;
		this.description = description;
	}

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public Topic getTopic() {
		return topic;
	}

	public void setTopic(Topic topic) {
		this.topic = topic;
	}

	public String getDescription() {
		return description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	

	public List<Question> getQuestions() {
		return questions;
	}

	public void setQuestions(List<Question> questions) {
		this.questions = questions;
	}
	
	public void addQuestions(Question question) {
		this.questions.add(question);
	}

	@Override
	public String toString() {
		return "Exam [ description=" + description  + ", Topic=" + topic+ ",  num_questions"+" ]";
	}
	
	
	
}
