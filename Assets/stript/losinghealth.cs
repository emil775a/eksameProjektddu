using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class losinghealth : MonoBehaviour
{
	// Start is called before the first frame update
	private void OnTriggerEnter(Collider col)
	{
		GameControlScript.health -= 1;
	}
}
