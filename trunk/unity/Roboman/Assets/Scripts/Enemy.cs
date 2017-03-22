using System.Collections;
using UnityEngine;
using UnityStandardAssets._2D;

public class Enemy : MonoBehaviour
{
    public float respawnTime = 0.5f;
    public GameObject enemy;
    public LifeLoss lifeLoss;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.gameObject.GetComponent<PlatformerCharacter2D>().isDying)//|| lifeLoss.isDying == true)
                return;
            Debug.Log("Enemy Dead");
            gameObject.GetComponent<Animator>().SetTrigger("deathPumpkin");
            lifeLoss.isDying = true;
            StartCoroutine(DestroyEnemy()); 
        }
    }

    public IEnumerator DestroyEnemy()
    {
        yield return new WaitForSeconds(0.1f);
        yield return new WaitForSeconds(respawnTime);
        Destroy(enemy);
    }
}
