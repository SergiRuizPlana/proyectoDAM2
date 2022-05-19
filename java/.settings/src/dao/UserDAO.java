package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import java.util.TreeMap;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import model.User; 

public class UserDAO {


	/***
	 * get all users
	 * @return ObservableList of users
	 */
	public static List<User> getUsers() {

		List<User> resultado=  new ArrayList<User>();
		String sqlComand= "select * from usrs";
		Statement stm;
		try {
			Conection.openConnection();
			stm = Conection.conn.createStatement();
			ResultSet r = stm.executeQuery(sqlComand); 
			while(r.next()) {
				User user = new User(r.getString("nif"),r.getString("fname"),r.getString("lname"),r.getString("userName"),r.getString("address"),r.getString("city"),r.getString("zip"),r.getString("phone"),r.getString("email") ,r.getString("psswd"),r.getString("role"));
				resultado.add(user);

			}
			stm.close();
			r.close();
			Conection.closeConnection();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return resultado;
	}



	/***
	 * Get all userNames and their passwords
	 * @return
	 */
	public  static TreeMap<String,String> getUsersNamesAndPsswd(){
		TreeMap <String,String> users=new TreeMap <String,String>();
		String sqlComand= "select userName,psswd from usrs";
		Statement stm2;
		try {
			Conection.openConnection();
			stm2 = Conection.conn.createStatement();
			ResultSet r2 = stm2.executeQuery(sqlComand); 
			while(r2.next()) {
				users.put(r2.getString(1),r2.getString(2));
			}
			stm2.close();
			Conection.closeConnection();
		} catch (Exception e) {
			e.printStackTrace();
		}
		System.out.println(users);
		return users;
	}



	/***
	 * 
	 */

	public static List<User> searchByNif(String nif) {

		List<User> resultado= new ArrayList<User>();
		String sqlComand= "select * from usr where nif like ? ";

		try {
			Conection.openConnection();
			PreparedStatement	stm = Conection.conn.prepareStatement(sqlComand);
			stm.setString(1,"%"+nif+"%");
			ResultSet r = stm.executeQuery();
			while(r.next()) {
				User user = new  User(r.getString("nif"),r.getString("fname"),r.getString("lname"),r.getString("userName"),r.getString("address"),r.getString("city"),r.getString("zip"),r.getString("phone"),r.getString("email") ,r.getString("psswd"),r.getString("role"));
				resultado.add(user);
			}
			stm.close();
			r.close();
			Conection.closeConnection();
			return resultado;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
	}

	
	/***
	 * 
	 * @param role: the role of current user
	 * @param userData array of all user info (nif, username, fname, lname, address, city, zip, phone, psswd) IN THIS ORDER!!
	 * @return true: if the user was created successfully 
	 * 					false: if the user was not created
	 */
	
	public static boolean insertUser(User usr) {
		String sqlComand="";
	
			sqlComand="insert into usr(nif, userName, fname, lname, address, city, zip, phone, psswd, email, role) values(?,?,?,?,?,?,?,?,?,?,?)";		 

		try {
			Conection.openConnection();
			PreparedStatement pstm= Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,usr.getNif());
			pstm.setString(2,usr.getUserName() );
			pstm.setString(3,usr.getFname());
			pstm.setString(4,usr.getLname());
			pstm.setString(5,usr.getAdress());
			pstm.setString(6,usr.getCity());
			pstm.setString(7,usr.getZip());
			pstm.setString(8,usr.getPhone());
			pstm.setString(9,usr.getPsswd());
			pstm.setString(10,usr.getEmail());
			pstm.setString(11,usr.getRole());
			pstm.executeUpdate();
			pstm.close();
			Conection.closeConnection();
			return true;
		} catch (Exception e) {
			e.printStackTrace();
			return false;
		}
	
	}

	public static User checkCredentials(String userName,String psswd) {
		String sqlComand="select * from usr where userName=? and psswd=?";
		User usr=null;
		try {
			Conection.openConnection();
			PreparedStatement pstm =Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1, userName);
			pstm.setString(2, psswd);
			ResultSet r =pstm.executeQuery();
			if(r.next()) {
				usr = new User(r.getString("nif"),r.getString("fname"),r.getString("lname"),r.getString("userName"),r.getString("address"),r.getString("city"),r.getString("zip"),r.getString("phone"),r.getString("psswd"),r.getString("email"),r.getString("role"));
			}
			pstm.close();
			Conection.closeConnection();
			return usr;
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
	}
	
	
	
	public static boolean changePasswd(String username, String passwd) {
		String sqlComand="update usr set psswd=? where userName=?";		
		try {
			Conection.openConnection();
			PreparedStatement pstm= Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,passwd );
			pstm.setString(2,username );
			pstm.executeUpdate();
			pstm.close();
			Conection.closeConnection();
			return true;
		} catch (Exception e) {
			return false;
		}
	}
	
	public static boolean changeUserName(String usernameOld, String usernameNew) {
		String sqlComand="update usr set userName=? where userName=?";		
		try {
			Conection.openConnection();
			PreparedStatement pstm= Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,usernameNew );
			pstm.setString(2,usernameOld );
			pstm.executeUpdate();
			pstm.close();
			Conection.closeConnection();
			return true;
		} catch (Exception e) {
			return false;
		}
	}
	
	/***
	 * 
	 * @param userInfo 
	 * @return
	 */
	
	public  static boolean updateUser(String[] userInfo,String userName) {
		String sqlComand="update usr set nif=?, fname=?, lname=?, address=?, city=?, zip=?, phone=?, email=? where userName=?";		
		try {
			Conection.openConnection();
			PreparedStatement pstm= Conection.conn.prepareStatement(sqlComand);
			pstm.setString(1,userInfo[0] );
			pstm.setString(2,userInfo[1] );
			pstm.setString(3,userInfo[2] );
			pstm.setString(4,userInfo[3] );
			pstm.setString(5,userInfo[4] );
			pstm.setString(6,userInfo[5] );
			pstm.setString(7,userInfo[6] );
			pstm.setString(8,userInfo[7] );
			pstm.setString(9,userName );
			pstm.executeUpdate();
			pstm.close();
			Conection.closeConnection();
			return true;
		} catch (Exception e) {
		e.printStackTrace();
			return false;
		}
		
	}



}
