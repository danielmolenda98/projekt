using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPumpkin : MonoBehaviour
{
    public GameObject gameObject1;
    public GameObject player;
    public float respawnTime = 0.5f;
    public Vector2 spawnPoint;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject)
        {
            gameObject.GetComponent<Animator>().SetTrigger("deathPumpkin");
            StartCoroutine(enemy1());
        }
    }

    public IEnumerator enemy1()
    {
        yield return new WaitForSeconds(0.1f);
        yield return new WaitForSeconds(respawnTime);
        Destroy(gameObject1);
        gameObject1.transform.position = spawnPoint;


    }


}
