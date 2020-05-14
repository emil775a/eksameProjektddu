
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSlippery : MonoBehaviour
{

    Rigidbody player;
    public float jumpForce = 7.5f; 
    [SerializeField] private bool onGround;
    public float airSpeed = 100f;
    float orgSpeed;
    
    PlayerMovementSlippery playerMovement;

    void Start()
    {
        foreach (var e in Input.GetJoystickNames())
        {
            Debug.Log("joystick: " + e);
        }
//        Debug.Log(Input. ().Length);
        player = GetComponent<Rigidbody>();
        onGround = true;
        playerMovement = GetComponent<PlayerMovementSlippery>();
        orgSpeed = playerMovement.speed;
    }

    void Update()
    {
        if (Input.GetButtonDown("JumpController") && onGround == true)
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
            playerMovement.speed = orgSpeed;
        }
        if (onGround == false)
        {
            playerMovement.speed = airSpeed;
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            onGround = true;
            if (other.gameObject.CompareTag("ground"))
            {
                onGround = true;
                playerMovement.speed = orgSpeed;
            }
            if (onGround == false)
            {
                playerMovement.speed = airSpeed;
            }
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            onGround = false;
            playerMovement.speed = airSpeed;
        }
    }
}