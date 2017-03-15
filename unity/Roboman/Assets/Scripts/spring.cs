using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spring : MonoBehaviour
{
    public RigidbodyConstraints constraints;
    public bool freezePosition;
    private Rigidbody2D rgdBody;
    public float jumpHeight;
    public LayerMask mask;
    private Rigidbody rb;

    private void Awake()
    {
        rgdBody = GetComponent<Rigidbody2D>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "spring")
        {
            rgdBody.AddForce(Vector2.up * 1240);
            if (jumpHeight == 1240);
                rgdBody.velocity = Vector3.zero;
        }
     }
}
