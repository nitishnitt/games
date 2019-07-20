using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour {
    public keycode key;
    //public owncontroller oc;
    // Use this for initialization
    public GameObject gameoverpanel;
    public GameObject hud;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       // Debug.Log(key.keypicked);
	}
    private void OnTriggerEnter(Collider other)
    {
       // Debug.Log(oc.keypicked1);
       Debug.Log(owncontroller.keypicked1);
        if(other.tag=="player" && owncontroller.keypicked1 )
        {
            hud.SetActive(false);
            gameoverpanel.SetActive(true);
            Debug.Log("won the gameeeee!!!!");

        }
    }
}
