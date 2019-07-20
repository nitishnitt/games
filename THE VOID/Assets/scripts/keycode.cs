using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycode : MonoBehaviour {
    public bool keypicked ;
  // public owncontroller oc;
    public GameObject key;
    public int a;

    void Start()
    {
        keypicked = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            keypicked = true;
            // oc.keypicked1 = true;
            owncontroller.keypicked1 = true;
            Destroy(key);
            
            Debug.Log( "keypicked");
        }
    }
    // Use this for initialization
   
}
