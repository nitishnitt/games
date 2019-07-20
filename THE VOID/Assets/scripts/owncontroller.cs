using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class owncontroller : MonoBehaviour {
    public Fixedbutton button;
    public bulletbutton button2;
    public FixedJoystick LeftJoystick;
    public FixedTouchField TouchField;
    protected Rigidbody Rigidbody;
    protected float CameraAngleY;
    protected float CameraAngleSpeed=0.1f;
    protected float CameraPosY;
    protected float CameraPosSpeed=0.01f;
    public Animator animator;
    public float JumpForce=50f;
    public Vector3 test;
    public enemyhealth eh;
    protected AudioSource aud;
    //public float playerhealth;
    //protected Actions Actions;
    //protected PlayerController PlayerController;
    public GameObject player;
    public AudioClip ac;
    public static bool keypicked1;
   
    void Start () {
        Rigidbody = GetComponent<Rigidbody>();
        // Actions = GetComponent<Actions>();
        // PlayerController = GetComponent<PlayerController>();
        //playerhealth = 100;
        //keypicked1 = false;
        Debug.Log(keypicked1+"  key picked variable");
    }
    

    void Awake()
    {
        aud = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update () {
        //Debug.Log(keypicked1);
        var input = new Vector3(LeftJoystick.inputVector.x, 0, LeftJoystick.inputVector.y);
        
        

        var vel = Quaternion.AngleAxis(CameraAngleY + 180, Vector3.up) * input * 5f;
        transform.rotation = Quaternion.AngleAxis(CameraAngleY + Vector3.SignedAngle(Vector3.forward, input.normalized + Vector3.forward * 0.0001f, Vector3.up) + 180, Vector3.up);
        Rigidbody.velocity = new Vector3(vel.x, Rigidbody.velocity.y, vel.z);

        CameraAngleY += TouchField.TouchDist.x * CameraAngleSpeed;
        CameraPosY = Mathf.Clamp(CameraPosY - TouchField.TouchDist.y * CameraPosSpeed, 0, 5f);

        Camera.main.transform.position = player.transform.position+test + Quaternion.AngleAxis(CameraAngleY, Vector3.up) * new Vector3(0 , CameraPosY , 4 );
        Camera.main.transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 2f - Camera.main.transform.position, Vector3.up);
        if (Rigidbody.velocity.magnitude > 3f)
        {
            animator.SetBool("aim", false);
            animator.SetFloat("speed", 1f);
        }
        else if (Rigidbody.velocity.magnitude > 0.5f)
        {
            animator.SetBool("aim", false);
            animator.SetFloat("speed", 0.5f);
        }
        else
        {
            animator.SetBool("aim", false);
            animator.SetFloat("speed", 0f);
        }

        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0));
        //Ray ra = new Ray(cam.transform.position, new Vector3(Screen.width / 2f, Screen.height / 2f, 0));
        Debug.DrawRay(ray.origin, ray.direction, Color.red);
        if (button.Pressed1)
        {
            animator.SetBool("aim", true);
            animator.SetFloat("speed", 0f);
            Debug.Log("yess");

        }
        if (button2.Pressed2)
        {
            animator.SetBool("aim", true);
            animator.SetFloat("speed", 0f);
            //Debug.Log("yess");
          
            RaycastHit hitinfo;
            aud.Play() ;
            if (Physics.Raycast(ray, out hitinfo,10000))
            {
                Debug.Log(hitinfo);
                var other = hitinfo.collider.GetComponent<Shootable>();
                if (other != null)
                {
                    other.GetComponent<Rigidbody>().AddForceAtPosition((hitinfo.point-transform.position).normalized * 500f, hitinfo.point);
                   // other.GetComponent<Rigidbody>().AddForceAtPosition(new Vector3(0, 0, 500), hitinfo.point);
                }
                var other1 = hitinfo.collider.GetComponent<Shootable1>();
                if (other1 != null)
                {
                    // other.GetComponent<Rigidbody>().AddForceAtPosition((hitinfo.point - transform.position).normalized * 500f, hitinfo.point);
                    // other.GetComponent<Rigidbody>().AddForceAtPosition(new Vector3(0, 0, 500), hitinfo.point);
                    Debug.Log("enemy hit");
                    eh.delta -= 0.25f;
                }
            }
        }
        //shooooooooooooooooooooooooot
        

    }
}
