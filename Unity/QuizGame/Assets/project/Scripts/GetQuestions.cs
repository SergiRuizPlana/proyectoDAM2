using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;
using UnityEngine.UI; 



public class GetQuestions : MonoBehaviour{

    public GameObject questionParent;
    List <Question> questions = new List<Question> ();
    
    void Start() {
         questions = Question.ConnectToDB();
         for (int i = 0; i <30; i++) {

            GameObject question =questionParent.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject; 
            if(i<questions.Count) {

            question.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Text>().text=questions[i].answer1;   
            question.transform.GetChild(1).gameObject.transform.GetChild(0).GetComponent<Text>().text=questions[i].answer2;   
            question.transform.GetChild(2).gameObject.transform.GetChild(0).GetComponent<Text>().text=questions[i].answer3;   
            question.transform.GetChild(3).gameObject.transform.GetChild(0).GetComponent<Text>().text=questions[i].answer4;   
            question.transform.GetChild(4).GetComponent<Text>().text=questions[i].question;   
            question.transform.GetChild(5).GetComponent<Text>().text=questions[i].id_question;  
            question.transform.GetChild(6).GetComponent<Text>().text=questions[i].correctAnswer+"";     
            }else{
                questionParent.transform.GetChild(i).gameObject.SetActive(false);
            }
         }
    } 


}


