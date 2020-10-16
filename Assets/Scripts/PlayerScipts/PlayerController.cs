﻿//Author : Colin
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public float speed = 1f;
    public float turnSpeed = 0.15f;
    Rigidbody rb;
    Vector2 movementVel;

    
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(movementVel.x * speed, rb.velocity.y, movementVel.y * speed );
        // Quaternion lookRot = new Quaternion(Quaternion.LookRotation(movementVel).x ,Quaternion.LookRotation(movementVel).y ,0, Quaternion.LookRotation(movementVel).w);
        // transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, turnSpeed);
        if(rb.velocity != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(rb.velocity);
    }

    void OnMovement(InputValue value){
        //Debug.Log(value.Get<Vector2>());
        movementVel = value.Get<Vector2>();
        movementVel.Normalize();
        
    }

    void OnInteract(){
    
    }

    void OnAttack1(){
        //basic attack
    }
    
    void OnAttack2(){
        //attack based on creature
    }

    void OnAttack3(){
        //attack based on creature
    }
}