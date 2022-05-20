using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SubmitQuestion : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject question;
    public QuestionResult updateTotalQuestions;
    
    public AudioSource succes;

    public AudioSource fail;

    public void submit(int answerNum)
    {
        int correctAnswer = int.Parse(question.transform.GetChild(6).GetComponent<Text>().text);
        if(correctAnswer==answerNum){
          question.transform.GetChild(answerNum - 1).GetComponent<Image>().color = new Color32(50, 168, 54, 100);
          succes.Play();
          updateTotalQuestions.setAsserts();
        }else{
          updateTotalQuestions.setFails();
          question.transform.GetChild(answerNum - 1).GetComponent<Image>().color = new Color32(237, 9, 5, 100);
          question.transform.GetChild(correctAnswer-1).GetComponent<Image>().color = new Color32(50, 168, 54, 100); 
          fail.Play();
        }
        string id = question.transform.GetChild(5).GetComponent<Text>().text;
       
        question.transform.GetChild(0).GetComponent<Button>().interactable = false;
        question.transform.GetChild(1).GetComponent<Button>().interactable = false;
        question.transform.GetChild(2).GetComponent<Button>().interactable = false;
        question.transform.GetChild(3).GetComponent<Button>().interactable = false;

    }
}
