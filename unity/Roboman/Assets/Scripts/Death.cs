using System.Collections;
using UnityEngine;
using UnityStandardAssets._2D;

public class Death : MonoBehaviour
{
    //public bool colliders;
    public uiManager uiObj;
    public GameObject player;
    public bool isDying;
    
    private void Start()
    {
        uiObj = GameObject.FindObjectOfType(typeof(uiManager)) as uiManager;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && isDying == false)
        {
            collision.gameObject.GetComponent<PlatformerCharacter2D>().Die();
            uiObj.lifesUpdate();          
        }
    }


}