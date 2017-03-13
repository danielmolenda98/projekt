using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector2 spawnPoint;
    public float respawnTime = 2f;
    public void KillPlayer()
    {
        StartCoroutine(PlayerDie());
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "spikes")
        {
            StartCoroutine(PlayerDie());
        }
    }

    public IEnumerator PlayerDie()
    {
        yield return new WaitForSeconds(1f);
        yield return new WaitForSeconds(respawnTime);
        gameObject.transform.position = spawnPoint;
    }
}