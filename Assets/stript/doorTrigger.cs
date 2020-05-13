using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{

    [SerializeField]

    GameObject nyplatform;


    public new Vector3 location;

    void OnTriggerEnter(Collider other)
	{

        nyplatform.transform.position = location;

    }


}
