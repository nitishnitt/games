using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour {

    public float speed;
    private float waitTime;
    public float startWaitTime;
    Animator anim;
    public Vector3 moveSpot;
    // minX = -34 , maxX = 34 , minY = -18, maxY = 18
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public enemyhealth eh;
    NavMeshAgent nmg;
    public GameObject player;
    public float dist;
    public GameObject bullet;
    public GameObject enemy;
	// Use this for initialization
	void Start () {
        waitTime = startWaitTime;
        //moveSpot.position = new Vector3(Random.Range(minX,maxX),0,Random.Range(minY,maxY));
        nmg = GetComponent<NavMeshAgent>();
        anim=GetComponent<Animator>();
        moveSpot = new Vector3(Random.Range(minX, maxX), 0, Random.Range(minY, maxY));
        anim.SetBool("move", true);
    }
	
	// Update is called once per frame
	void Update () {

        dist = Vector3.Distance(transform.position, player.transform.position);
        //Debug.Log(dist);
       // Debug.Log(player.transform.position);
        if (dist<=30)
        {
            moveSpot = player.transform.position;
            nmg.SetDestination(moveSpot);
            anim.SetBool("move", true);
        }
        if(dist<20)
        {
           // GameObject bulletObject = Instantiate(bullet, transform.position+new Vector3(0,2f,0), Quaternion.identity)  as GameObject;
          // bulletObject.GetComponent<bulletprop>().enemy = enemy;
        
        }
        nmg.SetDestination(moveSpot);
        
            if(eh.playerdeath)
        {
            nmg.enabled = false;
        }
        //transform.position = Vector3.MoveTowards(transform.position,moveSpot.position,speed*Time.deltaTime);
        if(Vector3.Distance(transform.position,moveSpot) < 0.5f)
        {
            //Debug.Log("Changedd....");
            if(waitTime <= 0)
            {
                moveSpot = new Vector3(Random.Range(minX, maxX), 0, Random.Range(minY, maxY));
                waitTime = startWaitTime;
                anim.SetBool("move", true);
            }
            else
            {
                //Debug.Log(waitTime + "      " + Time.captureFramerate);
                waitTime -= Time.deltaTime;
                anim.SetBool("move", false);
            }
        }
	}
    
}
