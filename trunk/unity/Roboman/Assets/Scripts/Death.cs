using System.Collections;
using UnityEngine;

public class Death : MonoBehaviour
{
    public Vector3 spawnPoint;
    public uiManager uiObj;
    public GameObject player;
    public float respawnTime = 0.5f;
    private void Start()
    {
        uiObj = GameObject.FindObjectOfType(typeof(uiManager)) as uiManager;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Animator>().SetTrigger("Death");
            StartCoroutine(playerDie());
            uiObj.lifesUpdate();
            
        }
    }

    public IEnumerator playerDie()
    {
        yield return new WaitForSeconds(1f);
        yield return new WaitForSeconds(respawnTime);
        player.transform.position = spawnPoint;
    }
}