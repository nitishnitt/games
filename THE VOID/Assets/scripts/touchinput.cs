using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class touchinput : MonoBehaviour {
    public FixedJoystick LeftJoystick;
    public Fixedbutton button;
   protected ThirdPersonUserControl Control;
    public FixedTouchField TouchField;
    // Use this for initialization
    protected float CameraAngle;
    protected float CameraAngleSpeed = 0.2f;
    void Start () {
        Control = GetComponent<ThirdPersonUserControl>();
	}
	
	// Update is called once per frame
	void Update () {
        Control.m_Jump = button.Pressed;
        Control.Hinput = LeftJoystick.inputVector.x;
        Control.Vinput = LeftJoystick.inputVector.y;
        

        CameraAngle += TouchField.TouchDist.x * CameraAngleSpeed;

        Camera.main.transform.position = transform.position + Quaternion.AngleAxis(CameraAngle, Vector3.up) * new Vector3(0, 3, 4);
        Camera.main.transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 2f - Camera.main.transform.position, Vector3.up);

    }
}



