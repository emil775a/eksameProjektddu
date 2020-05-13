using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow : MonoBehaviour
{
	Vector3 minimum;
	Vector3 maximum;

    static float t = 0.0f;
	bool bigCube = false;

    public Vector3 big;

	public Vector3 small;

	public float masssmall;
	public float massbig;
	public Rigidbody rb;
    public string growButton = "joystick button 0";

	float startTime = 0f;
	public float transformSpeed = 1f;
	bool growingOrShrinke = false;
	float fractionOfTime = 0;
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(growButton) && !bigCube)
		{
			startTime = Time.time;
			growingOrShrinke = true;
			maximum = big;
			minimum = transform.localScale;

			transform.localScale = big;
			bigCube = true;
			Debug.Log("grow");
			rb = GetComponent<Rigidbody>();
			rb.mass = massbig;
			Time.timeScale = 1;
		}
	 
        else if (Input.GetKeyDown(growButton) && bigCube)
		{
			startTime = Time.time;
			growingOrShrinke = true;
			maximum = small;
			minimum = transform.localScale;
			bigCube = false;
			transform.localScale = small;
			Debug.Log("shrink");
			rb = GetComponent<Rigidbody>();
			rb.mass = masssmall;
		}
        if(growingOrShrinke){
			fractionOfTime = (Time.time - startTime) * transformSpeed;
			transform.localScale = Vector3.Lerp(minimum, maximum, fractionOfTime);

		}
	}

}



