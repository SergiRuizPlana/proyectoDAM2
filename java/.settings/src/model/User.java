package model;

public class User {
	
	public enum Role {ADMIN ,TEACHER,STUDENT};
	
	private String nif;
	private String fname;
	private String lname;
	private String adress;
	private String city;
	private String zip;
	private String phone;
	private String psswd;
	private Role role;

	public User(String nif, String fname, String lname, String adress, String city, String zip, String phone,
			String psswd, Role role) {
		super();
		this.nif = nif;
		this.fname = fname;
		this.lname = lname;
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

	public Role getRole() {
		return role;
	}

	public void setRole(Role role) {
		this.role = role;
	}

	@Override
	public String toString() {
		return "User [nif=" + nif + ", fname=" + fname + ", lname=" + lname + ", adress=" + adress + ", city=" + city
				+ ", zip=" + zip + ", phone=" + phone + ", psswd=" + psswd + ", role=" + role + "]";
	}
	
	public String getFullName() {
		return fname +" "+ lname;
	}
	
}
