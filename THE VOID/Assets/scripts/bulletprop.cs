using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletprop : MonoBehaviour {
    Vector3 dir;
    //public GameObject player;
    public GameObject enemy;
    public float speed;
    Rigidbody rb;
    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        //dir = player.transform.forward;
        dir = enemy.transform.forward;
    }
	
	// Update is called once per frame
	void Update () {
        
        
       transform.position += dir * speed * Time.deltaTime;
        
	}
}
