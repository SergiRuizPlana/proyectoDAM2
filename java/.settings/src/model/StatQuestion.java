package model;


public class StatQuestion {

	private String questionId;
	private int total_hits; 
	private int total_misses;
	private int total_blank;

	
	public StatQuestion(String questionId, int total_hits, int total_misses, int total_blank) {
		super();
		this.questionId = questionId;
		this.total_hits = total_hits;
		this.total_misses = total_misses;
		this.total_blank = total_blank;
	}


	public String getQuestion() {
		return questionId;
	}


	public void setQuestion(String question) {
		this.questionId = question;
	}



	public int getTotal_hits() {
		return total_hits;
	}


	public void setTotal_hits(int total_hits) {
		this.total_hits = total_hits;
	}


	public int getTotal_misses() {
		return total_misses;
	}


	public void setTotal_misses(int total_misses) {
		this.total_misses = total_misses;
	}


	public int getTotal_blank() {
		return total_blank;
	}


	public void setTotal_blank(int total_blank) {
		this.total_blank = total_blank;
	}


	@Override
	public String toString() {
		return "StatQuestion [questionId=" + questionId + ", total_hits=" + total_hits + ", total_misses="
				+ total_misses + ", total_blank=" + total_blank + "]";
	}






}
