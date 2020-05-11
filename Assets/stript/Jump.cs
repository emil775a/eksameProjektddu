
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    Rigidbody player;
    public float jumpForce = 7.5f; 
    private bool onGround;

    void Start()
    {
        foreach (var e in Input.GetJoystickNames())
        {
            Debug.Log("joystick: " + e);
        }
//        Debug.Log(Input. ().Length);
        player = GetComponent<Rigidbody>();
        onGround = true;
    }

    void Update()
    {
        if (Input.GetButton("JumpController") && onGround == true)
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