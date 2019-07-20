using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hint : MonoBehaviour {
    SpriteRenderer sr;
    CapsuleCollider2D cc;
	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
        cc = GetComponent<CapsuleCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /* private void OnCollisionEnter2D(Collision2D collision)
     {
         if (collision.gameObject.tag == "player")
             Debug.Log("yessssss");
     }*/
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            sr.enabled = true;
            cc.isTrigger = false;
        }
            //Debug.Log("go right");
    }
}
