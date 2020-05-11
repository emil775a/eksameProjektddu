using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow : MonoBehaviour
{
	bool bigCube = false;

    public Vector3 medium;

	public Vector3 big;

	public Vector3 small;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

		if (Input.GetKeyDown(KeyCode.Space) && !bigCube)
		{
			transform.localScale = medium;
			bigCube = true;
			
		}
		else if (Input.GetKeyDown(KeyCode.Space) && bigCube)
		{
			transform.localScale = big;
			bigCube = true;
			
		}
	 
        if (Input.GetKeyDown(KeyCode.Space) && bigCube)
		{
			bigCube = false;
			transform.localScale = small;
			Debug.Log("shrink");
		}

}
}


