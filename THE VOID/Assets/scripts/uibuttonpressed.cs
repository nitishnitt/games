using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uibuttonpressed : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ButtonPressed(GameObject pressedobjectref)
    {
        Debug.Log("ButtonPressed=" + pressedobjectref.name);
        uimanager1.uiManagerInst.onbuttonpressed(pressedobjectref.name);

    }

}
