﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            transform.localScale = new Vector3 (Random.Range(0.2f, 5.0f), 1, Random.Range(0.2f, 5.0f));
        }
           
    }
}
