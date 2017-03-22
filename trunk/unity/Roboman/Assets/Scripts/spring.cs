using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    public float jumpHeight;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Rigidbody2D rgdBody = collision.gameObject.GetComponent<Rigidbody2D>();
            rgdBody.AddForce(Vector2.up * 1240);
            if (jumpHeight == 1240) ;
            rgdBody.velocity = Vector3.zero;
        }
    }
}
