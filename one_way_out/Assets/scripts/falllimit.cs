using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class falllimit : MonoBehaviour
{
    public playercontroller pc;
    public Animator anim;
    public BoxCollider2D bc;
    float cooldown;
    bool fall = false;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown <= 0 && fall==true)
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

            bc.isTrigger = false;
           // anim.SetBool("jump", false);
            //anim.SetBool("idle", true);
            anim.SetBool("death", true);
            pc.enabled = false;
            Debug.Log(cooldown);
            fall = true;
            cooldown = 3.0f;


        }
    }
}

