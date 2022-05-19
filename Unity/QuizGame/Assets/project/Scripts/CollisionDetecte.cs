using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetecte : MonoBehaviour
{
     public GameObject question;
     public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

       void OnCollisionEnter(Collision obj){
           Debug.Log("IJidji");
        question.SetActive(true);  
        sphere.SetActive(false);
    }

    void OnTriggerEnter(){
         Debug.Log("IJidji");
    }
}
