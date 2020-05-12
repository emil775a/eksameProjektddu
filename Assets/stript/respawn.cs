using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
	[SerializeField]
	GameObject door;
	private void OnTriggerEnter(Collider col)
	{
		door.transform.position = new Vector3(17, 5, -11);
	}
}
