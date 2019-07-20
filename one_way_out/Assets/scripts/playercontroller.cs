using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class playercontroller : MonoBehaviour
{
    //public moveright moveright;
    //public moveleft moveleft;
   // public jumpp jumpp;                                                           
    public float speed;
    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer r;
    public float speed2;
    public bool faceright = true;
    public float jumpforce;
    public bool onground;
    private float dirx;
	// Use this for initialization
	void Start ()
    {
        //jumpforce = 5;
        Vector2 upvect = new Vector2(0,jumpforce);
        //speed = 5.0f;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        r = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(onground)
            dirx = CrossPlatformInputManager.GetAxis("Horizontal") * speed;
        if(!onground)
            dirx = CrossPlatformInputManager.GetAxis("Horizontal") * speed2;
        //Debug.Log(dirx);

        /* if (CrossPlatformInputManager.GetButtonDown("jump"))
             //Debug.Log("jump");
             rb.AddForce(new Vector2(0, jumpforce));*/

        if (Mathf.Abs(dirx)>0 && rb.velocity.y==0)
            anim.SetBool("run", true);
        else
            anim.SetBool("run", false);

        if (!onground)
            anim.SetBool("jump", true);
        if (onground)
        {
            anim.SetBool("jump", false);
            anim.SetBool("idle", true);
        }

        if (dirx>0)
            {  if (faceright==false)
                {

                    r.flipX = false;
                    faceright = true;
               }
            //anim.SetBool("run", true);

            rb.velocity = new Vector2(dirx, rb.velocity.y);
            //Debug.Log(rb.velocity.x);

            }
            else if (dirx<0)
            {   if(faceright==true)
                {
                    //anim.SetBool("run", true);
                    //Debug.Log(rb.velocity.x);
                    r.flipX = true;
                    faceright = false;

                }
            //anim.SetBool("run", true);
            rb.velocity = new Vector2(dirx, rb.velocity.y);



        }
             if((CrossPlatformInputManager.GetButtonDown("jump")))
            {   if (onground)
                {

                   // anim.SetBool("jump", true);
                    rb.AddForce(new Vector2(0, jumpforce));
                   
                    onground = false;
                }
            }

           
        // if(rb.velocity.x>0||rb.velocity.x<0)

        //     anim.SetBool("run", true);

        // else
        //     anim.SetBool("run", false);

        //  Debug.Log(rb.velocity.x);


    }
    /*  public void OnCollisionEnter2D(Collision2D collision)
      {
          if (collision.gameObject.tag == "object")
              Debug.Log("go right");
      }*/
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        { onground = true;
        }
        if (collision.gameObject.tag == "platbot")
        {
           

             Debug.Log("hit yessss");
        }

    }
   /* public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
            Debug.Log("go right");
    }*/
}
