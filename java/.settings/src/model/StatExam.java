package model;

import java.util.Date;

public class StatExam {

	private String nif;
	private int hits;
	private int  misses;
	private int blank;
	private Date statDate;
	private Topic topic;
	private String student;
	
	

	public StatExam( String nif, int hits, int misses, int blank,Date statDate,Topic topic) {
		super();
		this.nif = nif;
		this.hits = hits;
		this.misses = misses;
		this.blank = blank;
		this.statDate=statDate;
	}



	public String getNif() {
		return nif;
	}



	public void setNif(String nif) {
		this.nif = nif;
	}



	public Topic getTopic() {
		return topic;
	}



	public void setTopic(Topic topic) {
		this.topic = topic;
	}



	public String getStudent() {
		return student;
	}



	public void setStudent(String student) {
		this.student = student;
	}



	public int getHits() {
		return hits;
	}



	public void setHits(int hits) {
		this.hits = hits;
	}



	public int getMisses() {
		return misses;
	}



	public void setMisses(int misses) {
		this.misses = misses;
	}



	public int getBlank() {
		return blank;
	}



	public void setBlank(int blank) {
		this.blank = blank;
	}



	public Date getStatDate() {
		return statDate;
	}



	public void setStatDate(Date statDate) {
		this.statDate = statDate;
	}



	@Override
	public String toString() {
		return "StatExam [  nif=" + nif + ", hits=" + hits + ", misses=" + misses + ", blank="
				+ blank + ", statDate=" + statDate + "]";
	}



	
	
	
	
	
}
