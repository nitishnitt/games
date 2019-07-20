using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spikes : MonoBehaviour {
    SpriteRenderer sr;
    EdgeCollider2D ec;
    public Animator anim;
    public playercontroller pc;
    float cooldown;
    bool fall;
	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
        ec = GetComponent<EdgeCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (cooldown <= 0 && fall == true)
        {
            Debug.Log(cooldown);

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            cooldown = 3;
        }
        else
            cooldown -= Time.deltaTime;// Debug.Log("go right");

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            sr.enabled = true;
            ec.isTrigger = false;
           
            //anim.SetBool("jump", false);
           // anim.SetBool("idle", true);
            anim.SetBool("death", true);
            pc.enabled = false;
            fall = true;
            cooldown = 3;
           // Debug.Log("go right");
        }

    }
}
