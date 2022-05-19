using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Animator playerAnim;
    public bool walking;
    public GameObject player;
	 
	 private AudioSource run = player.GetComponents<AudioSource>()[1];
	 private AudioSource walk = player.GetComponents<AudioSource>()[0];
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (!walk.isPlaying)
            {
               walk.Play();
            }
           
        }
        if (Input.GetKeyUp(KeyCode.W))
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
        if (Input.GetKey(KeyCode.A))
        {
            if (walk.isPlaying)
            {
            walk.Pause();
			run.Play();
               
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (run.isPlaying)
            {
				run.Pause();
			}
        }

       

        if (walking == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {          
                playerAnim.SetTrigger("run");
                playerAnim.ResetTrigger("walk");
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                playerAnim.ResetTrigger("run");
                playerAnim.SetTrigger("walk");
            }
        }
    }
 
}

