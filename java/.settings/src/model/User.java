package model;

public class User {
	
	public enum Role {ADMIN ,TEACHER,STUDENT};
	
	private String nif;
	private String fname;
	private String lname;
	private String userName;
	private String adress;
	private String city;
	private String zip;
	private String phone;
	private String psswd;
	private String role;

	public User(String nif, String fname, String lname,String userName, String adress, String city, String zip, String phone,
			String psswd, String role) {
		super();
		this.nif = nif;
		this.fname = fname;
		this.lname = lname;
		this.userName=userName;
		this.adress = adress;
		this.city = city;
		this.zip = zip;
		this.phone = phone;
		this.psswd = psswd;
		this.role = role;
	}

	public String getNif() {
		return nif;
	}

	public void setNif(String nif) {
		this.nif = nif;
	}

	public String getFname() {
		return fname;
	}

	public void setFname(String fname) {
		this.fname = fname;
	}

	public String getLname() {
		return lname;
	}

	public void setLname(String lname) {
		this.lname = lname;
	}

	public String getAdress() {
		return adress;
	}

	public void setAdress(String adress) {
		this.adress = adress;
	}

	public String getCity() {
		return city;
	}

	public String getUserName() {
		return userName;
	}

	public void setUserName(String userName) {
		this.userName = userName;
	}

	public void setCity(String city) {
		this.city = city;
	}

	public String getZip() {
		return zip;
	}

	public void setZip(String zip) {
		this.zip = zip;
	}

	public String getPhone() {
		return phone;
	}

	public void setPhone(String phone) {
		this.phone = phone;
	}

	public String getPsswd() {
		return psswd;
	}

	public void setPsswd(String psswd) {
		this.psswd = psswd;
	}

	public String getRole() {
		return role;
	}

	public void setRole(String role) {
		this.role = role;
	}


	@Override
	public String toString() {
		return "User [nif=" + nif + ", fname=" + fname + ", lname=" + lname + ", userName=" + userName + ", adress="
				+ adress + ", city=" + city + ", zip=" + zip + ", phone=" + phone + ", psswd=" + psswd + ", role="
				+ role + "]";
	}

	public String getFullName() {
		return fname +" "+ lname;
	}
	
}
