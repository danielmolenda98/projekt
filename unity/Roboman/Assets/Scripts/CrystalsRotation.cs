﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalsRotation : MonoBehaviour
{
    public float speed = 2f; 

	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0,speed, 0);	
	}
}
