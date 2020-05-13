using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class farvepådoor : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject cube;
	private Renderer rend;



	void OnTriggerEnter(Collider other)
	{
		GetComponent<Renderer>().material.color = Color.red;
	}
}
