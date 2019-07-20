using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class touchtest : MonoBehaviour {

    public Text display;


    // Update is called once per frame
    public Vector2 startPos;
    public Vector2 direction;
    public float dirx;
    public float diry;
    public bool directionChosen;
    void Update()
    {
        // Track a single touch as a direction control.
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Handle finger movements based on touch phase.
            switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                    startPos = touch.position;
                    directionChosen = false;
                    break;

                // Determine direction by comparing the current touch position with the initial one.
                case TouchPhase.Moved:
                    direction = touch.position - startPos;
                    display.text = "StartPos :" + startPos + " : Endpos : " + touch.position;
                    dirx = startPos.x-touch.position.x;
                    diry = startPos.y - touch.position.y;



                    break;

                // Report that a direction has been chosen when the finger is lifted.
                case TouchPhase.Ended:
                    directionChosen = true;
                    
                    break;
            }
        }
        if (directionChosen)
        {
            if (dirx < 0 && diry <0)
            {
                display.text = "moved right and up";
            }
            if (dirx >0 && diry<0 )
            {
                display.text = "moved left and up";
            }
            if (diry < 0 && dirx<0)
            {
                display.text = "moved up";
            }
            if (diry > 0)
            {
                display.text = "moved down";
            }

            // Something that uses the chosen direction...
            Debug.Log("Hello");
        }
    }
}
