using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float respawnTime = 0.5f;
    public GameObject gmObj;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Animator>().SetTrigger("deathPumpkin");
            StartCoroutine(destroyEnemy()); 
        }
    }

    public IEnumerator destroyEnemy()
    {
        yield return new WaitForSeconds(0.1f);
        yield return new WaitForSeconds(respawnTime);
        Destroy(gmObj);
    }

}
