using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class massforDoor : MonoBehaviour
{

    public float mass;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider col)
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = mass;
    }
}
