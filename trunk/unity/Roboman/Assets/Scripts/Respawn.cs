using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector2 spawnPoint;

    void OnTriggerStay(Collider other)
        {
        if (other.gameObject.tag == "Player")
        {
            other.transform.position = spawnPoint;
        }
    }
}
