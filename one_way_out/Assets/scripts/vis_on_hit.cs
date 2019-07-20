using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vis_on_hit : MonoBehaviour {
    public GameObject go;
    public Rigidbody2D rb;
    public BoxCollider2D bc;
    public SpriteRenderer sr;
    private int hitcount;
    public GameObject g;
	// Use this for initialization
	void Start () {
        hitcount = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (hitcount == 3)
            g.active = true;

        //Debug.Log(rb.velocity);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player" && rb.velocity.y>0 )
        {
            sr.enabled = true;
            bc.isTrigger = false;
            hitcount++;
            Debug.Log(hitcount);
            
        }
      
    }
   /* public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player" && rb.velocity.y > 0)
        {
            Debug.Log("hit");

            // Debug.Log("go right");
        }

    }*/
}
