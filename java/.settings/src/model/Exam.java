package model;

public class Exam {
	
	private String id;
	private String topic;
	private String description;
	private int n_questions;
	
	public Exam(String id, String topic, String description, int n_questions) {
		super();
		this.id = id;
		this.topic = topic;
		this.description = description;
		this.n_questions = n_questions;
	}

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public String getTopic() {
		return topic;
	}

	public void setTopic(String topic) {
		this.topic = topic;
	}

	public String getDescription() {
		return description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	public int getN_questions() {
		return n_questions;
	}

	public void setN_questions(int n_questions) {
		this.n_questions = n_questions;
	}

	@Override
	public String toString() {
		return "Exam [ description=" + description  + ", Topic=" + topic+ ",  num_questions"+n_questions+" ]";
	}
	
	
	
}
