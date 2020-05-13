using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
	[SerializeField]

	GameObject player;

	[SerializeField]
	GameObject players;

	public new Vector3 player1;

	public new Vector3 player2;

	private void OnTriggerEnter(Collider col)
       
	{
		player.transform.position = player1;

		players.transform.position = player2;
	}
}
