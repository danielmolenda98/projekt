using System.Collections;
using UnityEngine;

public class Death : MonoBehaviour
{
    public Vector3 spawnPoint;
    public uiManager uiObj;
    public GameObject gmObj;
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
        yield return new WaitForSeconds(0.2f);
        yield return new WaitForSeconds(respawnTime);
        gmObj.transform.position = spawnPoint;
    }
}