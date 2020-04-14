﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    Rigidbody player;
    private float jumpForce = 7.5f; 
    private bool onGround;

    void Start()
    {
        player = GetComponent<Rigidbody>();
        onGround = true;
    }

    void Update()
    {
        if (Input.GetButton("Jump") && onGround == true)
        {
            player.velocity = new Vector3(0f, jumpForce, 0f);
            onGround = false;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            onGround = true;
        }
    }
}