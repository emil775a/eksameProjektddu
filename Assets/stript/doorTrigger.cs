using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    public Material[] material;
    public Color myColor;
    public GameObject door;
    public GameObject player1;
    private Renderer rend;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name== "player1")
        {
            myColor = Color.white;
        }
    }

}
