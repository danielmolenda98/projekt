﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float respawnTime = 0.5f;
    public uiManager uiObj;

    private void Start()
    {
        uiObj = GameObject.FindObjectOfType(typeof(uiManager)) as uiManager;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision is CircleCollider2D)
        {
            gameObject.GetComponent<Animator>().SetTrigger("deathPumpkin");
            StartCoroutine(destroyEnemy()); 
            GetComponent<Collider2D>().enabled = false; 
        }

        else if (collision is BoxCollider2D)
        {
           collision.gameObject.GetComponent<Animator>().SetTrigger("Death");
           collision.gameObject.GetComponent<Respawn>().KillPlayer();
           uiObj.lifesUpdate();
        }
    }

    public IEnumerator destroyEnemy()
    {
        yield return new WaitForSeconds(0.1f);
        yield return new WaitForSeconds(respawnTime);
        Destroy(gameObject);
    }
}