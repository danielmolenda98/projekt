using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector2 spawnPoint;
    public float respawnTime = 2f;
    public uiManager uiObj;

    void Start()
    {
        uiObj = GameObject.FindObjectOfType(typeof(uiManager)) as uiManager;
    }

    public void KillPlayer()
    {
        StartCoroutine(PlayerDie());
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.gameObject.GetComponent<Animator>().SetTrigger("Death");
            uiObj.lifesUpdate();
        }
    }

    public IEnumerator PlayerDie()
    {
        yield return new WaitForSeconds(1f);
        yield return new WaitForSeconds(respawnTime);
        gameObject.transform.position = spawnPoint;
    }
}