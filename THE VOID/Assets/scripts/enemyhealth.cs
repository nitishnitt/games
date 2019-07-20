using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemyhealth : MonoBehaviour {
    public Material mat;
    float cooldowntime;
    public float delta;
    Animator anim;
    public Patrol pat;
    public GameObject player;
    public bool playerdeath=false;
    NavMeshAgent nmg;
    public enemygun eg;
    public GameObject key;
    int a;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        //cooldowntime = 3f;
        mat.SetFloat("_Fill", 1f);
        mat.SetFloat("_Delta", -1f);
        delta = 1f;
        nmg = GetComponent<NavMeshAgent>();
        a = 1;
    }
	
	// Update is called once per frame
	void Update () {
        /*if(cooldowntime<=0 && delta>0)
       {
            delta -= 0.25f;
            mat.SetFloat("_Fill",delta);
            cooldowntime = 3f;
       }
        else
        {
           cooldowntime -= Time.deltaTime;
        }*/
        mat.SetFloat("_Fill", delta);

        if (delta == 0)
        {
            playerdeath = true;
            anim.SetBool("death",true);
            anim.SetBool("move", false);
            pat.enabled = false;
            nmg.enabled = false;
            eg.enabled = false;
            if (a == 1)
            {
                Instantiate(key, transform.position + new Vector3(0, 2, 0), Quaternion.identity);
                a = 0;
            }
        }
	}
}
