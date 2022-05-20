using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class QuestionResult : MonoBehaviour
{
    public GameObject uiText;
    public GameObject numDone;
    private int numResponse = 0;
    public GameObject assertsText;
    public GameObject failsText;

    public GameObject asserts;
    public GameObject fails;
    public void setAsserts()
    {
        assertsText.GetComponent<Text>().text = "Asserts:" + (int.Parse(asserts.GetComponent<Text>().text) + 1);
        asserts.GetComponent<Text>().text=(int.Parse(asserts.GetComponent<Text>().text) + 1)+"";
        numResponse = int.Parse(numDone.GetComponent<Text>().text) + 1;
        numDone.GetComponent<Text>().text = numResponse + "";
        uiText.GetComponent<Text>().text = numResponse + "/30";
    }

    public void setFails()
    {
        failsText.GetComponent<Text>().text = "Fails:" + (int.Parse(fails.GetComponent<Text>().text) + 1);
        fails.GetComponent<Text>().text=(int.Parse(fails.GetComponent<Text>().text) + 1)+"";
        numResponse = int.Parse(numDone.GetComponent<Text>().text) + 1;
        numDone.GetComponent<Text>().text = numResponse + "";
        uiText.GetComponent<Text>().text = numResponse + "/30";
    }
}
