using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Animator playerAnim;
    public bool walking;
    public AudioSource walk;

    public AudioSource run;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.S) ||Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            if (!walk.isPlaying)
            {
               walk.Play();
            }
           
        }
        if (Input.GetKeyUp(KeyCode.W)||Input.GetKeyUp(KeyCode.S) ||Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
			if (walk.isPlaying)
            {
            walk.Pause();
               
            }
        }
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerAnim.SetTrigger("walk");
            playerAnim.ResetTrigger("idle"); 
			walking=true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.ResetTrigger("walk");
            playerAnim.SetTrigger("idle"); 
			walking=false;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerAnim.SetTrigger("back");
            playerAnim.ResetTrigger("idle");
           
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnim.ResetTrigger("back");
            playerAnim.SetTrigger("idle"); 
        }
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) && !Input.GetKeyDown(KeyCode.LeftShift))
        {
             playerAnim.SetTrigger("walk");
            playerAnim.ResetTrigger("idle"); 
            
        }

        if ((Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) && !walking )
        {
           playerAnim.ResetTrigger("walk");
            playerAnim.SetTrigger("idle"); 
            
        }
       
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) && Input.GetKey(KeyCode.LeftShift))
        {
             playerAnim.SetTrigger("run");
            playerAnim.ResetTrigger("walk"); 
        }


        if ((Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) && Input.GetKeyUp(KeyCode.LeftShift))
        {
             playerAnim.ResetTrigger("run");
             playerAnim.SetTrigger("walk"); 
        }

       

        if (walking == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {          
                playerAnim.SetTrigger("run");
                playerAnim.ResetTrigger("walk");
                 walk.Pause();
                 run.Play();
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                playerAnim.ResetTrigger("run");
                playerAnim.SetTrigger("walk");
                run.Pause();
                walk.Play();
            }
        }else{
            run.Pause();
             walk.Pause();
        }
    }
 
}

