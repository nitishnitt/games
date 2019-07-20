using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class door_open : MonoBehaviour {
    public GameObject door1;
    public GameObject door2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            door1.active = false;
            door2.active = true;
            Debug.Log("hitttt");
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
}
