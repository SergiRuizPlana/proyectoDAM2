package tests;

import static org.junit.Assert.fail;
import static org.junit.jupiter.api.Assertions.*;

import org.junit.Assert;
import org.junit.jupiter.api.Test;

import dao.UserDAO;
import model.User;

class CreateUsers {

	@Test
	void test() {
		User usr=new User("C12345678","fname", "lname","userName", "adress", "city","2000","964454", "psswd", "email.com", "STUDENT");
		assert UserDAO.insertUser(usr); 
	}

}
