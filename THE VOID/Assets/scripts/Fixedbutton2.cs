using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Fixedbutton2 : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector]
    public bool Pressed2;

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed2 = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed2 = false;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
