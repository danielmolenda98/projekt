using System.Collections;
using UnityEngine;

public class LifeLoss : MonoBehaviour
{
    public uiManager uiObj;
    public Vector2 spawnPoint;
    public float respawnTime = 2f;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        uiObj = GameObject.FindObjectOfType(typeof(uiManager)) as uiManager;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Animator>().SetTrigger("Death");
            uiObj.lifesUpdate();
            collision.gameObject.GetComponent<Respawn>().KillPlayer();
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