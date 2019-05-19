using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 6.0f;
    public float turnspeed = 5.0f;
    public float jumpSpeed = 50.0f;

    public Rigidbody myRigidbody;



    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.AddForce(0,jumpSpeed*100,0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(0, 0, 1 * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(0, 0, -1 * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(0, turnspeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Rotate(0, -turnspeed, 0);
        }

    }
}
