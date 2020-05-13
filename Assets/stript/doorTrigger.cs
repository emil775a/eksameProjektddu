using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    public GameObject cube;
    private Renderer rend;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // This will get the OBJECT to CHANGE COLOR on KEY PRESS
        if (Input.GetKeyDown(KeyCode.R))
            GetComponent<Renderer>().material.color = Color.red;
        print("A Key Pressed For Red Color");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Cube")
        {
            transform.parent.GetComponent<Renderer>().material.color = Color.red;
        }
    }

}
