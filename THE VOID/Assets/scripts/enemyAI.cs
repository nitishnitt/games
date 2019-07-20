using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    private Vector3 nextDestination;
    private Vector3 initalPosition;
    Animator anim;
    public float enemySpeed = 0.05f;
    public bool quad1;
    public bool quad2;
    public bool quad3;
    public bool quad4;
    private void Start()
    {
        initalPosition = transform.position;
        RandomPosition();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        Move();
    }

    private void RandomPosition()
    {
        float xRnd = Random.Range(-10, 10);
        float zRnd = Random.Range(-10, 10);

        nextDestination = new Vector3(xRnd, transform.position.y, zRnd);

    }
    private void Move()
    {
        //gameObject.transform.Translate(nextDestination);
        //gameObject.transform.position = nextDestination;
        
        gameObject.transform.position = Vector3.MoveTowards(transform.position, nextDestination, enemySpeed);
        anim.SetBool("walk",true);
        if (transform.position == nextDestination)
        {
            RandomPosition();
        }
        if (nextDestination.x > 0 && nextDestination.z > 0)
        {
            float xRnd = Random.Range(0, 10);
            float zRnd = Random.Range(0, -10);
        }
        if (nextDestination.x > 0 && nextDestination.z < 0)
        {
            float xRnd = Random.Range(0, -10);
            float zRnd = Random.Range(0, -10);
        }
        if (nextDestination.x < 0 && nextDestination.z > 0)
        {
            float xRnd = Random.Range(0, 10);
            float zRnd = Random.Range(0, 10);
        }
        if (nextDestination.x < 0 && nextDestination.z < 0)
        {
            float xRnd = Random.Range(0, -10);
            float zRnd = Random.Range(0, 10);
        }
    }
}
