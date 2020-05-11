using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow : MonoBehaviour
{
	bool bigCube = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space) && !bigCube);
		{
			transform.localScale = new Vector3(2, 2, 2);
			bigCube = true;

			Debug.Log("grow");
		}
	 
        if (Input.GetKeyDown(KeyCode.Space) && bigCube)
		{
			bigCube = false;
			transform.localScale = new Vector3(1, 1, 1);

			Debug.Log("shrink");
		}
	}

}

	

