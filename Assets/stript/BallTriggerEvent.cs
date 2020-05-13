using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTriggerEvent : MonoBehaviour
{

    [SerializeField]
    public GameObject target;

    private void OnTriggerEnter(Collider other)
    {
        target.GetComponent<Renderer>().material.color = Color.magenta;
    }
}
