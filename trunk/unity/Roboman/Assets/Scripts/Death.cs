using UnityEngine;
using System.Collections;
using System;

public class Death : MonoBehaviour
{
    public Vector3 spawnPoint;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            new WaitForSeconds(2.0f);
            other.transform.position = spawnPoint;
            transform.position = new Vector3(0.0f, 0.0f, -5.0f);
        }
    }
}