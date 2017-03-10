using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doublejumping : MonoBehaviour
{
    public RigidbodyConstraints constraints;
    public bool freezePosition;
    private Rigidbody2D rigidbody;
    public float jumpHeight;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private int isJumping = 2;
    public LayerMask mask;

    private Rigidbody rb;

    // Update is called once per frame
    void Update()
    {

        //Jumping Section
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isJumping == 2)
            {
                rigidbody.AddForce(Vector2.up * 800);
                isJumping = 1;
            }

            else if (isJumping == 1)
            {
                rigidbody.velocity = Vector3.zero;
                rigidbody.AddForce(Vector2.up * 800);
                isJumping = 0;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isJumping = 2;
        }
    }
}