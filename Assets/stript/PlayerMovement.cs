﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 12f;
    public string horizontalInput = "Horizontal";
    public string verticalInput = "Vertical";

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis(horizontalInput) * (speed * Time.deltaTime);
        float z = Input.GetAxis(verticalInput) * (speed * Time.deltaTime);

        rb.velocity = new Vector3(x, rb.velocity.y, z);
    }

}