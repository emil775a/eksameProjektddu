using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.82f;
    public float jumpHeight = 3.5f;
    public string horizontalInput = "Horizontal";
    public string verticalInput = "Vertical";

    public LayerMask groundMask;
    public Transform groundCheck;
    public float groundDistance = 0f;

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis(horizontalInput);
        float z = Input.GetAxis(verticalInput);

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("JumpController") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

}
