using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spring : MonoBehaviour
{
    public RigidbodyConstraints constraints;
    public bool freezePosition;
    private Rigidbody2D rigidbody;
    public float jumpHeight;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    public LayerMask mask;

    private Rigidbody rb;

    void Update()
    {
       
            if (collision.GameObjectTag == "Player")
            {
                
                rigidbody.AddForce(Vector2.up * 1200);

                if (GameObjectTag.JumpHeight = 1200)
                {
                    rigidbody.velocity = Vector3.zero;


                }
            }

    }

}