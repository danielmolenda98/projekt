using UnityEngine;
using System.Collections;
using System;

public class Death : MonoBehaviour
{
    public Vector3 spawnPoint;
    public float respawnTime = 3.0f;

    void Start()
    {
        spawnPoint = gameObject.transform.position;
        StartCoroutine(Respawn());
    }

    IEnumerator Respawn()
    {
        // Te dwie linijki potrzebne tylko do pokazania efektu
        yield return new WaitForSeconds(respawnTime);
        gameObject.transform.position = spawnPoint;
    }
}