using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : MonoBehaviour {
    public Material mat;
    public float health;
    Animator anim;
    public float delta;
    public float fill;
    public owncontroller oc;
    public GameObject gameoverpanel;
    public GameObject hud;
    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        delta = 0;
        fill = 1;
        mat.SetFloat("_Delta", delta);
        mat.SetFloat("_Fill", fill);
        health = 100f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        mat.SetFloat("_Delta", delta);
        if(delta==1)
        {
            anim.SetBool("death", true);
            oc.enabled = false;
            hud.SetActive(false);
            gameoverpanel.SetActive(true);

        }
        
	}
}
