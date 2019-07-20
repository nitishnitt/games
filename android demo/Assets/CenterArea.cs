using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterArea : MonoBehaviour
{
    private Vector3 firstpoint;
    private Vector3 secondpoint;
    private float xAngle = 0.0f; //angle for axes x for rotation
    private float yAngle = 0.0f;
    private float xAngTemp = 0.0f; //temp variable for angle
    private float yAngTemp = 0.0f;
    private GameObject playRot;


    void Start()
    {

        //dtext = GameObject.Find("debugText").GetComponent<Text>();

        firstpoint = new Vector3(0, 0, 0);
        secondpoint = new Vector3(0, 0, 0);

        playRot = GameObject.Find("Player");

        xAngle = 0.0f;
        yAngle = 0.0f;

        transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f);
    }

    void Update()
    {
        //Check count touches
       // if (PlayerController.instance.TabletMode == 1)
        {
            if (Input.touchCount > 0)
            {
                //Touch began, save position
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    firstpoint = Input.GetTouch(0).position;
                    xAngTemp = xAngle;
                    yAngTemp = yAngle;
                }
                //Move finger by screen
                if (Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    secondpoint = Input.GetTouch(0).position;
                    //Mainly, about rotate camera. For example, for Screen.width rotate on 180 degree
                    yAngle = yAngTemp - (secondpoint.y - firstpoint.y) * 90.0f / Screen.height;

                    if (yAngle < 0)
                        yAngle += 360;
                    if (yAngle > 360)
                        yAngle -= 360;

                    if (yAngle > 90 && yAngle < 270)
                        xAngle = xAngTemp - (secondpoint.x - firstpoint.x) * 180.0f / Screen.width;
                    else
                        xAngle = xAngTemp + (secondpoint.x - firstpoint.x) * 180.0f / Screen.width;

                    if (xAngle < 0)
                        xAngle += 360;

                    if (xAngle > 360)
                        xAngle -= 360;

                    transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f);

                }
            }
        }
    }


    //public CenterJoystick centerJoyStick; // the game object containing the LeftJoystick script
    //public Transform rotationTarget; // the game object that will rotate to face the input direction
    //public float moveSpeed = 6.0f; // movement speed of the player character
    //public int rotationSpeed = 8; // rotation speed of the player character
    ////public Animator animator; // the animator controller of the player character
    //private Vector3 leftJoystickInput; // holds the input of the Left Joystick
    //private Rigidbody rigidBody; // rigid body component of the player character

    //void Start()
    //{
    //    if (transform.GetComponent<Rigidbody>() == null)
    //    {
    //        Debug.LogError("A RigidBody component is required on this game object.");
    //    }
    //    else
    //    {
    //        rigidBody = transform.GetComponent<Rigidbody>();
    //    }

    //    if (centerJoyStick == null)
    //    {
    //        Debug.LogError("The left joystick is not attached.");
    //    }

    //    if (rotationTarget == null)
    //    {
    //        Debug.LogError("The target rotation game object is not attached.");
    //    }
    //}

    //void Update()
    //{
    //}

    //void FixedUpdate()
    //{
    //    // get input from both joysticks
    //    leftJoystickInput = centerJoyStick.GetInputDirection();

    //    float xMovementLeftJoystick = leftJoystickInput.x; // The horizontal movement from joystick 01
    //    float zMovementLeftJoystick = leftJoystickInput.y; // The vertical movement from joystick 01	

    //    // if there is no input on the left joystick
    //    //if (leftJoystickInput == Vector3.zero)
    //    //{
    //    //    animator.SetBool("isRunning", false);
    //    //}

    //    // if there is only input from the left joystick
    //    if (leftJoystickInput != Vector3.zero)
    //    {
    //        // calculate the player's direction based on angle
    //        float tempAngle = Mathf.Atan2(zMovementLeftJoystick, xMovementLeftJoystick);
    //        xMovementLeftJoystick *= Mathf.Abs(Mathf.Cos(tempAngle));
    //        zMovementLeftJoystick *= Mathf.Abs(Mathf.Sin(tempAngle));

    //        leftJoystickInput = new Vector3(xMovementLeftJoystick, 0, zMovementLeftJoystick);
    //        leftJoystickInput = transform.TransformDirection(leftJoystickInput);
    //        leftJoystickInput *= moveSpeed;

    //        // rotate the player to face the direction of input
    //        Vector3 temp = transform.position;
    //        temp.x += xMovementLeftJoystick;
    //        temp.z += zMovementLeftJoystick;
    //        Vector3 lookDirection = temp - transform.position;
    //        if (lookDirection != Vector3.zero)
    //        {
    //            rotationTarget.localRotation = Quaternion.Slerp(rotationTarget.localRotation, Quaternion.LookRotation(lookDirection), rotationSpeed * Time.deltaTime);
    //        }
    //        //if (animator != null)
    //        //{
    //        //    animator.SetBool("isRunning", true);
    //        //}

    //        // move the player
    //      //  rigidBody.transform.Translate(leftJoystickInput * Time.fixedDeltaTime);
    //    }
    //}
}
