using System.Collections;
using UnityEngine;
using UnityStandardAssets._2D;

public class Death : MonoBehaviour
{
    //public bool colliders;
    public uiManager uiObj;
    public GameObject player;
    
    private void Start()
    {
        uiObj = GameObject.FindObjectOfType(typeof(uiManager)) as uiManager;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlatformerCharacter2D>().Die();
            
            uiObj.lifesUpdate();

            
        }
    }


}