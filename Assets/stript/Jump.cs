
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    Rigidbody player;
    public float jumpForce = 7.5f; 
    private bool onGround;
    public float airSpeed = 100f;
    public string horizontalInput = "Horizontal";
    public string verticalInput = "Vertical";
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
        if (Input.GetButtonDown("JumpController") && onGround == true)
        {
            player.velocity = new Vector3(0f, jumpForce, 0f);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            onGround = true;
        }
        while (onGround != true)
        {
            float x = Input.GetAxis(horizontalInput) * (airSpeed * Time.deltaTime);
            float z = Input.GetAxis(verticalInput) * (airSpeed * Time.deltaTime);

            player.velocity = new Vector3(x, player.velocity.y, z);
        }
    }
}