using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Fixedbutton : MonoBehaviour,IPointerUpHandler,IPointerDownHandler
{
    [HideInInspector]
    public bool Pressed;

    [HideInInspector]
    public bool Pressed1;
    public GameObject bullet;
    public GameObject player;
    Vector3 loc;
    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed1 = true;
       // GameObject bulletObject = Instantiate(bullet, loc, Quaternion.identity) as GameObject;
       // bulletObject.GetComponent<bulletprop>().player = player;
        Debug.Log("yes");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed1 = false;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        loc = player.transform.position + new Vector3(0, 2f, 0);
    }
}
