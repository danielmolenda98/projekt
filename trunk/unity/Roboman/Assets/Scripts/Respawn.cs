using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
   public Transform spawnPoint;
    public float respawnTime = 2f;
    public GameObject gmObj;
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
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Animator>().SetTrigger("Death");
            uiObj.lifesUpdate();
            StartCoroutine(PlayerDie());
        }
    }

    public IEnumerator PlayerDie()
    {
        yield return new WaitForSeconds(1f);
        yield return new WaitForSeconds(respawnTime);
        gmObj.transform.position = spawnPoint.position;
    }
}