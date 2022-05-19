using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;
using UnityEngine.UI; 



public class GetQuestions : MonoBehaviour{

    public List<GameObject> question;
    List <Question> questions = new List<Question> ();
    
    void Start() {
         questions = Question.ConnectToDB();
         int i = 0;
         foreach (GameObject questio  in question ){
            questio.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Text>().text=questions[i].answer1;   
            questio.transform.GetChild(1).gameObject.transform.GetChild(0).GetComponent<Text>().text=questions[i].answer2;   
            questio.transform.GetChild(2).gameObject.transform.GetChild(0).GetComponent<Text>().text=questions[i].answer3;   
            questio.transform.GetChild(3).gameObject.transform.GetChild(0).GetComponent<Text>().text=questions[i].answer4;   
            questio.transform.GetChild(4).GetComponent<Text>().text=questions[i].question;   
            questio.transform.GetChild(5).GetComponent<Text>().text=questions[i].id_question;  
            questio.transform.GetChild(6).GetComponent<Text>().text=questions[i].correctAnswer+"";   
            Debug.Log(questions[i].correctAnswer);
             i++;
         } 
    } 


}


