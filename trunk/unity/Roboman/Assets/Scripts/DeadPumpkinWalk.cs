using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPumpkinWalk : MonoBehaviour
{
    public float respawnTime = 0.5f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject)
        {
            gameObject.GetComponent<Animator>().SetTrigger("deadPumpkin");
            StartCoroutine(enemy1());
        }
    }

    public IEnumerator enemy1()
    {
        yield return new WaitForSeconds(0.1f);
        yield return new WaitForSeconds(respawnTime);
        Destroy(gameObject);
    }
}