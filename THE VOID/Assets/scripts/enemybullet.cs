using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybullet : MonoBehaviour {
    Rigidbody rb;
    public float speed=5f;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(0, 0, speed, ForceMode.Impulse);
        Destroy(gameObject, 3f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
