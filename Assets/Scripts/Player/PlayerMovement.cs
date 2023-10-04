using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public Rigidbody2D myRigidbody;
    public float playerSpeed = 5;
    public Vector3 speed = new Vector2(10,10);
    
    void Start()
    {
        
    }


    void Update()
    {
       
    }

    private void FixedUpdate() 
    {
        playerMove();
    }

    private void playerMove()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0 );

        movement *= Time.deltaTime;

        transform.Translate(movement);
        
    }
}
