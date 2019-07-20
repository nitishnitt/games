using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;


public class moveright: MonoBehaviour, IPointerUpHandler, IPointerDownHandler
    {
        [HideInInspector]
        public bool right;
        // public GameObject bullet;
        // public GameObject player;
        Vector3 loc;
        public void OnPointerDown(PointerEventData eventData)
        {
        right = true;
            
        }

        public void OnPointerUp(PointerEventData eventData)
        {
        right = false;
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // loc = player.transform.position +new Vector3 (0,2f,0);
        }
    }

