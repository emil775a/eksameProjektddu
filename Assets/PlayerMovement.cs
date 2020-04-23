using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //  public CharacterController controller;

    Rigidbody rb;

    public float speed = 12f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * (speed * Time.deltaTime);
        float z = Input.GetAxis("Vertical") * (speed * Time.deltaTime);

        Vector3 move = new Vector3(x, rb.velocity.y, z); 

        rb.velocity = move;
       // controller.Move(move * speed * Time.deltaTime);
    }
}
