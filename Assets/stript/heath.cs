using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	private void OnTriggerEnter(Collider col)
	{
		GameControlScript.health -= 1;
	}
}


