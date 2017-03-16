using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector2 spawnPoint;
    public float respawnTime = 2f;
    public uiManager uiObj;
    public GameObject player;

    void Start()
    {
        uiObj = GameObject.FindObjectOfType(typeof(uiManager)) as uiManager;
    }

    public void KillPlayer()
    {
        StartCoroutine(playerDie());
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.gameObject.GetComponent<Animator>().SetTrigger("Death");
            StartCoroutine(playerDie());
        }
    }

    public IEnumerator playerDie()
    {
        yield return new WaitForSeconds(0.5f);
        yield return new WaitForSeconds(respawnTime);
        player.transform.position = spawnPoint;
    }
}