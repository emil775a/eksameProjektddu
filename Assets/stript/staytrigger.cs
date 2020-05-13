using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staytrigger : MonoBehaviour
{
	[SerializeField]

	GameObject cube;


	public new Vector3 parkour;

	public new Vector3 parkour1;

	private void OnTriggerEnter(Collider col)

	{
		cube.transform.position = parkour;

	
	}
    private void OnTriggerExit(Collider col)
	{
		cube.transform.position = parkour1;
	}
}
