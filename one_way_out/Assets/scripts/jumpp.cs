using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class jumpp : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector]
    public bool up;
    // public GameObject bullet;
    // public GameObject player;
    Vector3 loc;
    public void OnPointerDown(PointerEventData eventData)
    {
        up = true;

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        up = false;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
