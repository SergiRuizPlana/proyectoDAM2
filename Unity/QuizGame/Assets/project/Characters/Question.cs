using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;
using UnityEngine.UI;



public class SetQuestions : MonoBehaviour
{

    // after the sql query is executed we will have a filled users array
    List <Question> questions = new List<Question> ();
    
    // Use this for initialization
    void Start()
    {
        // initialize global users array
         questions = ConnectToDB();
    } 

    // function to connect to the db and the users list
    List <Question> ConnectToDB()
    { 
        try
        {
            // connect to the databases
            using (SqlConnection connection = new SqlConnection("workstation id=gestioEmpresa.mssql.somee.com;packet size=4096;user id=code24_SQLLogin_1;pwd=9kwyyyqmim;data source=gestioEmpresa.mssql.somee.com;persist security info=False;initial catalog=gestioEmpresa"))
            {
                // if open then the connection is established
                connection.Open();
                Debug.Log("connection established");
                // sql command
                string sql = "SELECT * from question";
                // execute sql command
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // read
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // each line in the output
                        while (reader.Read())
                        {
                            // to avoid SqlNullValueException
                            if (!reader.IsDBNull(0) & !reader.IsDBNull(1)  & !reader.IsDBNull(3))
                            {
                                // Skills list to be attached to each user object
                                //List skills = new List();
                                //// get output parameters
                                //string username = reader.GetString(0);
                                //string aboutString = reader.GetString(1);
                                //string skillsString = reader.GetString(3);

                               Debug.Log(reader.GetString(1));
                                // as we are getting a list of skills as 
                                // a single string delimited by comma
                                // we split the string
                                //string[] skillsList = skillsString.Split(',');
                                // we now iterate through each skill to initialize our
                                // skill object and put it into skills list
                                //foreach (string skillName in skillsList)
                                //{
                                //    // initialize a skill object with a trimmed string
                                //    Skill skill = new Skill(skillName.Trim());
                                //    // append to the skills array
                                //    skills.Add(skill);
                                //}
                                //// initialize User oobject
                                //User user = new User(username.Trim(), aboutString.Trim(), skills);
                                //users.Add(user);
                            }
                        }
                    }
                }
            }
        }
        catch (SqlException e)
        {
            Debug.Log(e.ToString());
        }
        return null;
    }
}

public class Question{
    public string question { get; set; }
    public string answer1 { get; set; }
    public string answer2 { get; set; }
    public string answer3 { get; set; }
    public string answer4 { get; set; }
    public int correctAnswer { get; set ;}

}
