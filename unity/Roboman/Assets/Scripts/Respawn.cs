using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector2 spawnPoint;
    public float respawnTime = 2f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "spikes")
        {
            StartCoroutine(enemyDie());
        }
    }

    public IEnumerator enemyDie()
    {
        yield return new WaitForSeconds(1f);
        yield return new WaitForSeconds(respawnTime);
        gameObject.transform.position = spawnPoint;
    }
}