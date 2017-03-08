using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour
{
    
    public Vector3 spawnPoint; 
    public GameObject player;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("fail");
            other.transform.position = spawnPoint;
        }
    }
}