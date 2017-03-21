using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Enemy : MonoBehaviour
{
    public float respawnTime = 0.5f;
    public GameObject enemy;
    public Death death;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.gameObject.GetComponent<PlatformerCharacter2D>().isDying)
                return;

            gameObject.GetComponent<Animator>().SetTrigger("deathPumpkin");
            death.isDying = true;
            StartCoroutine(destroyEnemy()); 
        }
    }

    public IEnumerator destroyEnemy()
    {
        yield return new WaitForSeconds(0.1f);
        yield return new WaitForSeconds(respawnTime);
        Destroy(enemy);
    }

}
