using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour
{
    
    public Vector3 startPoint; 
    public GameObject player;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
           gameObject.transform.position = startPoint;
        }
    }
}