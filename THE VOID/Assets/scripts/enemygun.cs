using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemygun : MonoBehaviour {
    public Transform gunEnd;
    public GameObject bullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            StartCoroutine("Shooting");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            StopCoroutine("Shooting");
        }
    }
    private IEnumerator Shooting ()
    {
        while(true)
        {
            Instantiate(bullet, gunEnd.position, gunEnd.rotation);
            yield return new WaitForSeconds(0.2f);
        }
    }
}
