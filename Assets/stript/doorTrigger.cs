using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
	public float massbig;
	public Rigidbody rb;
	


	void OnTriggerEnter(Collider other)
	{
		
		rb.mass = massbig;
		Debug.Log("mass call");
	}


}
