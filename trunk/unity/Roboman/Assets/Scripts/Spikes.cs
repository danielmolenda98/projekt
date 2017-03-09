﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public Transform spawnPoint;
    void OnTriggerEnter2D (Collider2D other)
    {
		if (other.gameObject.name == "Player")
        {
            other.transform.position = spawnPoint.position;
        }
	}
}
