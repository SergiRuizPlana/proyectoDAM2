package dao;


import java.sql.Connection;
import java.sql.DriverManager;

public class Conection {

	
	public static Connection conn;

	private static final String jdbcDriver = "com.microsoft.sqlserver.jdbc.SQLServerDriver";
	private static final String jdbcURL = "jdbc:sqlserver://gestioEmpresa.mssql.somee.com;packet size=4096;user=code24_SQLLogin_1;password=9kwyyyqmim;data source=gestioEmpresa.mssql.somee.com;persist security info=False;initial catalog=gestioEmpresa;encrypt=true;trustServerCertificate=true";

	public static void openConnection() throws Exception {
		Class.forName(jdbcDriver);
		conn = DriverManager.getConnection(jdbcURL);
	}


	public static void closeConnection() throws Exception {
		conn.close();
	}
}
