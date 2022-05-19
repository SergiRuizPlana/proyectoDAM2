using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using System.Data.SqlClient;
using UnityEngine.UI; 

public class Question  
{ 
    public string id_question { get; set; }
    public string question { get; set; }
    public string answer1 { get; set; }
    public string answer2 { get; set; }
    public string answer3 { get; set; }
    public string answer4 { get; set; }
    public int correctAnswer { get; set; }

    Question(string question, string answer1, string answer2, string answer3,string answer4, int correctAnswer){
        this.question = question;
        this.answer1 = answer1;
        this.answer2 = answer2;
        this.answer3 = answer3;
        this.answer4 = answer4;
        this.correctAnswer = correctAnswer;
    }


    public static List <Question> ConnectToDB(){  
        List <Question> questions = new List<Question>();
        try{
            // connect to the databases
            using (SqlConnection connection = new SqlConnection("workstation id=gestioEmpresa.mssql.somee.com;packet size=4096;user id=code24_SQLLogin_1;pwd=9kwyyyqmim;data source=gestioEmpresa.mssql.somee.com;persist security info=False;initial catalog=gestioEmpresa"))
            {
                // if open then the connection is established
                connection.Open();
               
                string sql = "SELECT * from questions ORDER BY newid()";
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
                                //// get output parameters
                                string id_questionText = reader.GetGuid(0)+"";
                                string questionText = reader.GetString(1);
                                string answer1Text = reader.GetString(2);
                                string answer2Text = reader.GetString(3);
                                string answer3Text = reader.GetString(4);
                                string answer4Text = reader.GetString(5);
                                int correctAnswerNum= reader.GetInt32(6);

                               Debug.Log(correctAnswerNum);
 
                                 Question question = new Question(questionText.Trim(), answer1Text.Trim(),answer2Text.Trim(),answer3Text.Trim(),answer4Text.Trim(), correctAnswerNum);
                                questions.Add(question);
                            }
                        }
                    }
                }
            }
            return questions;
        }
        catch (SqlException e)
        {
            Debug.Log(e.ToString());
        }
        return null;
    }
}


