package model;


import javafx.beans.property.SimpleStringProperty;
import javafx.beans.property.StringProperty;

public class UserFx {
	

	
	private StringProperty nif = new SimpleStringProperty();
	private StringProperty fname= new SimpleStringProperty();
	private StringProperty userName= new SimpleStringProperty();
	private StringProperty lname = new SimpleStringProperty();
	private StringProperty adress = new SimpleStringProperty();
	private StringProperty city = new SimpleStringProperty();
	private StringProperty zip = new SimpleStringProperty();
	private StringProperty phone= new SimpleStringProperty();
	private StringProperty psswd= new SimpleStringProperty();
	private StringProperty role= new SimpleStringProperty();
	
	public UserFx(String nif, String fname, String lname, String userName, String adress,
			String city, String zip, String phone, String psswd, String role) {
		super();
		this.nif = new SimpleStringProperty(nif);
		this.fname = new SimpleStringProperty(fname);
		this.lname = new SimpleStringProperty(lname);
		this.userName = new SimpleStringProperty(userName);
		this.adress = new SimpleStringProperty(adress);
		this.city = new SimpleStringProperty(city);
		this.zip = new SimpleStringProperty(zip);
		this.phone = new SimpleStringProperty(phone);
		this.psswd = new SimpleStringProperty(psswd);
		this.role = new SimpleStringProperty(role);
	}

	
	public final StringProperty nifProperty() {
		return this.nif;
	}
	

	public final String getNif() {
		return this.nifProperty().get();
	}
	

	public final void setNif(final String nif) {
		this.nifProperty().set(nif);
	}
	

	public final StringProperty fnameProperty() {
		return this.fname;
	}
	

	public final String getFname() {
		return this.fnameProperty().get();
	}
	

	public final void setFname(final String fname) {
		this.fnameProperty().set(fname);
	}
	

	public final StringProperty lnameProperty() {
		return this.lname;
	}
	

	public final String getLname() {
		return this.lnameProperty().get();
	}
	

	public final void setLname(final String lname) {
		this.lnameProperty().set(lname);
	}
	

	public final StringProperty adressProperty() {
		return this.adress;
	}
	

	public final String getAdress() {
		return this.adressProperty().get();
	}
	

	public final void setAdress(final String adress) {
		this.adressProperty().set(adress);
	}
	

	public final StringProperty cityProperty() {
		return this.city;
	}
	

	public final String getCity() {
		return this.cityProperty().get();
	}
	

	public final void setCity(final String city) {
		this.cityProperty().set(city);
	}
	

	public final StringProperty zipProperty() {
		return this.zip;
	}
	

	public final String getZip() {
		return this.zipProperty().get();
	}
	

	public final void setZip(final String zip) {
		this.zipProperty().set(zip);
	}
	

	public final StringProperty phoneProperty() {
		return this.phone;
	}
	

	public final String getPhone() {
		return this.phoneProperty().get();
	}
	

	public final void setPhone(final String phone) {
		this.phoneProperty().set(phone);
	}
	

	public final StringProperty psswdProperty() {
		return this.psswd;
	}
	

	public final String getPsswd() {
		return this.psswdProperty().get();
	}
	

	public final void setPsswd(final String psswd) {
		this.psswdProperty().set(psswd);
	}
	

	public final StringProperty roleProperty() {
		return this.role;
	}
	

	public final String getRole() {
		return this.roleProperty().get();
	}
	

	public final void setRole(final String role) {
		this.roleProperty().set(role);
	}


	public final StringProperty userNameProperty() {
		return this.userName;
	}
	


	public final String getUserName() {
		return this.userNameProperty().get();
	}
	


	public final void setUserName(final String userName) {
		this.userNameProperty().set(userName);
	}
	
	

	







	
}
