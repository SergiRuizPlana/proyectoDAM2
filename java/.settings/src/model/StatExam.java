package model;

import java.util.Date;

public class StatExam {

	private String examId;
	private String nif;
	private int hits;
	private int  misses;
	private int blank;
	private Date statDate;
	
	
	
	public StatExam(String examId, String nif, int hits, int misses, int blank,Date statDate) {
		super();
		this.examId = examId;
		this.nif = nif;
		this.hits = hits;
		this.misses = misses;
		this.blank = blank;
		this.statDate=statDate;
	}



	public String getExam() {
		return examId;
	}



	public void setExam(String exam) {
		this.examId = exam;
	}



	public String getStudent() {
		return nif;
	}



	public void setStudent(String nif) {
		this.nif = nif;
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
		return "StatExam [exam=" + examId + ", nif=" + nif + ", hits=" + hits + ", misses=" + misses + ", blank="
				+ blank + ", statDate=" + statDate + "]";
	}



	
	
	
	
	
}
