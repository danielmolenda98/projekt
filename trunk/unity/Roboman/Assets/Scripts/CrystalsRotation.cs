using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalsRotation : MonoBehaviour
{
    public float speed = 2f;
    private Renderer rend;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
        rend.sortingOrder = -10;  
    }
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0,speed, 0);	
	}
}
