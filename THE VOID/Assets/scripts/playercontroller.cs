using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {
    Animator anim;
    private void Awake()
    {
        anim = GetComponent < Animator>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("walk",true);
            anim.SetBool("idle", false);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("walk", false);
            anim.SetBool("idle", true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("jump1");
           
        }
    }
}
