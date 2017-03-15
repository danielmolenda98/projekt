using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{ 
    public uiManager uiObj;
    //public GameObject gmObj;

	// Use this for initialization
	void Start ()
    {
        uiObj = GameObject.FindObjectOfType(typeof(uiManager)) as uiManager;	
	}
	
    void OnTriggerEnter2D(Collider2D collision)
    {
        /*
        if(collision.gameObject.tag == "Player")
        {
            uiObj.pointsUpdate();
            Destroy(gameObject);
        }
        */
        if(collision.gameObject.tag == "Player")
        {
            uiObj.cristalsUpdate();
            Destroy(gameObject);
        }
    }
}
