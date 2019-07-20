using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_mov : MonoBehaviour {
    BoxCollider2D bc;
    float deltax;
    float deltay;
    bool moveallowed = false;
    Rigidbody2D rb;
	// Use this for initialization
	void Start ()
    {
        bc = GetComponent<BoxCollider2D>();
        rb=GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchpos = Camera.main.ScreenToWorldPoint(touch.position);
            switch(touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchpos))
                    {


                        deltax = touchpos.x - transform.position.x;
                        deltay = touchpos.y - transform.position.y;
                        moveallowed = true;
                        rb.freezeRotation = true;
                        rb.velocity = new Vector2(0, 0);
                        rb.gravityScale = 0;
                        GetComponent<BoxCollider2D>().sharedMaterial = null;

                    }
                    break;
                case TouchPhase.Moved:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchpos) && moveallowed)
                        rb.MovePosition(new Vector2(touchpos.x - deltax, touchpos.y - deltay));
                    break;
                case TouchPhase.Ended:
                    moveallowed = false;
                    rb.freezeRotation = false;
                    //rb.velocity = new Vector2(0, 0);
                    rb.gravityScale = 2;
                    GetComponent<BoxCollider2D>().sharedMaterial = null;

                    break;
            }
        }
		
	}
}
