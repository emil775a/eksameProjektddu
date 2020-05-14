using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementSlippery : MonoBehaviour
{
    Rigidbody rb;

    private bool onGround;
    public float speed = 12f;
    public string horizontalInput = "Horizontal";
    public string verticalInput = "Vertical";
    public float slipperyMod = 0.9f;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onGround == true)
        {

            float x = Input.GetAxis(horizontalInput) * (speed * Time.deltaTime);
            float z = Input.GetAxis(verticalInput) * (speed * Time.deltaTime);
            if (Mathf.Abs(x) > 0 || Mathf.Abs(z) > 0)
            {
                rb.velocity *= slipperyMod;
            }
            rb.AddForce(new Vector3(x, 0f, z));
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
