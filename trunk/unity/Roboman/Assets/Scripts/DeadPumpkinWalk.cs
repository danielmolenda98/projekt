using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPumpkinWalk : MonoBehaviour
{
    public GameObject gameObject1;
   // public uiManager uiObj;
    //public float respawnTime = 0.5f;

   // void Start()
   // {
   //     uiObj = GameObject.FindObjectOfType(typeof(uiManager)) as uiManager;
   // }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject)
        {
            collision.gameObject.GetComponent<Animator>().SetTrigger("deathPumpkin");
            //StartCoroutine(enemy());

        }
    }

   /* public IEnumerator enemy()
    {
        yield return new WaitForSeconds(0.1f);
        yield return new WaitForSeconds(respawnTime);
        Destroy(gameObject1);

    }*/
}