package dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List; 

import model.User; 

public class UserDAO {

	/***
	 * get all users
	 * @return ObservableList of users
	 */
	public static List<User> getUsers() {

		List<User> resultado=  new ArrayList<User>();
		String sqlComand= "select * from usrs where role='STUDENT'";
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
	 * Deprecated
	 */

	public static List<User> searchByNif(String nif) {

		List<User> resultado= new ArrayList<User>();
		String sqlComand= "select * from usrs where nif like ? ";

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
	 * @param usr. the user to insert
	 * @return true: if the user was created successfully 
	 * 					false: if the user was not created
	 */

	public static boolean insertUser(User usr) {
		String  sqlComand="insert into usrs (nif, userName, fname, lname, address, city, zip, phone, psswd, email, role) values(?,?,?,?,?,?,?,?,?,?,?)";		 

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


	/***
	 * Check if there is an user with the credentials passed
	 * @param userName
	 * @param psswd
	 * @return the user if exists, null if not exists
	 */
	public static User checkCredentials(String userName,String psswd) {
		String sqlComand="select * from usrs where userName=? and psswd=?";
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


	/***
	 * change an user password 
	 * @param username
	 * @param passwd
	 * @return
	 */
	public static boolean changePasswd(String username, String passwd) {
		String sqlComand="update usrs set psswd=? where userName=?";		
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



	/***
	 * change an user userName
	 * @param usernameOld
	 * @param usernameNew
	 * @return
	 */
	public static boolean changeUserName(String usernameOld, String usernameNew) {
		String sqlComand="update usrs set userName=? where userName=?";		
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
	 * update an user
	 * @param userInfo 
	 * @return
	 */

	public  static boolean updateUser(String[] userInfo,String nif) {
		String sqlComand="update usrs set nif=?, fname=?, lname=?, address=?, city=?, zip=?, phone=?, email=?,role=? where nif=?";		
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
			pstm.setString(9,userInfo[8] );
			pstm.setString(10,nif );
			pstm.executeUpdate();
			pstm.close();
			Conection.closeConnection();
			return true;
		} catch (Exception e) {
			e.printStackTrace();
			return false;
		}

	}



	/***
	 * delete an user
	 * @param nif
	 * @return
	 */
	public static boolean deleteUser(String nif) {
		String sql ="delete from usrs where nif=?";
		try {
			Conection.openConnection();
			PreparedStatement pstm= Conection.conn.prepareStatement(sql);
			pstm.setString(1,nif );
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
