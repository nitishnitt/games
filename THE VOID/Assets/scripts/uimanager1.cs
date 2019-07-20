using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class uimanager1 : MonoBehaviour {
    public Camera uicam;
    public Camera playercam;
    float cdt;
    float cdt2;
    public Animator anim;
    public Animator anim2;
    int a;
    int b;
    public GameObject htp;
	// Use this for initialization
	
    public static uimanager1 uiManagerInst;
    public GameObject hud;
    void Start()
    {
        uiManagerInst = this;
    }

    public void onbuttonpressed(string nameofbutton)
    {
        switch(nameofbutton)
        {
            case "restart":
                Debug.Log("workeddddd");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;
                
        }
    }
    // Update is called once per frame
    void Update () {

        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;
            Ray ray = uicam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log(hit.transform.gameObject.name);
                if(hit.transform.gameObject.name=="play")
                {
                    
                    anim.SetBool("death", true);
                    a = 1;
                    cdt = 4.0f;
                }
                if (hit.transform.gameObject.name == "htp")
                {

                    anim2.SetBool("death1", true);
                    b = 1;
                    cdt2 = 4.0f;
                }

            }
        }
        if (a == 1 && cdt <= 0)
        {
            playercam.depth = 2;
            cdt = .0f;
            a = 0;
            hud.SetActive(true);
        }
        else
        {
            cdt -= Time.deltaTime;
        }
        if (b == 1 && cdt2 <= 0)
        {
            
            cdt2 = 4.0f;
            b = 0;
            htp.SetActive(true);
            //hud.SetActive(true);
        }
        else
        {
            cdt2 -= Time.deltaTime;
        }

    }
}
