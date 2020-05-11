using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow : MonoBehaviour
{
	bool bigCube = false;

    public Vector3 big;

	public Vector3 small;

	public float masssmall;
	public float massbig;
	public Rigidbody rb;
    public string growButton = "joystick button 0";

	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(growButton) && !bigCube)
		{
			transform.localScale = big;
			bigCube = true;
			Debug.Log("grow");
			rb = GetComponent<Rigidbody>();
			rb.mass = massbig;
		}
	 
        else if (Input.GetKeyDown(growButton) && bigCube)
		{
			bigCube = false;
			transform.localScale = small;
			Debug.Log("shrink");
			rb = GetComponent<Rigidbody>();
			rb.mass = masssmall;
		}
	}

}

	

