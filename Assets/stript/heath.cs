using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	void OnTriggerEnter(Collider col)
	{
		gamecontrolscript.health -= 1;
	}
}
