using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcollisions : MonoBehaviour {
    
    public playerhealth ph;
	// Use this for initialization
	void Start () {
      //  mat.SetFloat("_Delta",0f);
      //  mat.SetFloat("_Fill",1f);
       // delta = 0f;
    }
	
	// Update is called once per frame
	void Update () {
       // mat.SetFloat("_Delta", delta);
      
        // mat.SetFloat("_Fill", fill);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet1")
        {
            ph.delta += 0.25f;
            
            Debug.Log("playerrrr hitttt");
            Debug.Log(ph.delta);
        }
    }
}
