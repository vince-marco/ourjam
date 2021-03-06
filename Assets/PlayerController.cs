﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 6.0f;
    public float turnspeed = 5.0f;
    public float jumpSpeed = 50.0f;

    public float disttoGround = 0.0f;

    Rigidbody myRigidbody;

    bool IsGrounded() {
        return Physics.Raycast(transform.position, -Vector3.up, disttoGround + 0.1f);
    }

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (IsGrounded()) {
            //Jumping
            if (Input.GetKeyDown(KeyCode.Space))
            {
                myRigidbody.AddForce(0, jumpSpeed * 100, 0);
            }
            //Moving Forwards
            if (Input.GetKey(KeyCode.W))
            {
                gameObject.transform.Translate(0, 0, 1 * speed * Time.deltaTime);
            }
            //Backpedaling
            if (Input.GetKey(KeyCode.S))
            {
                gameObject.transform.Translate(0, 0, -1 * speed * Time.deltaTime);
            }
            //Turn Right
            if (Input.GetKey(KeyCode.D))
            {
                gameObject.transform.Rotate(0, turnspeed, 0);
            }
            //Turn Left
            if (Input.GetKey(KeyCode.A))
            {
                gameObject.transform.Rotate(0, -turnspeed, 0);
            }
        }
    }
}
