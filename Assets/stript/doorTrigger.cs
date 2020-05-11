using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject door;
    private void OnTriggerEnter(Collider col)
    {
        door.transform.position += new Vector3(0, -4, 0);
    }
}
