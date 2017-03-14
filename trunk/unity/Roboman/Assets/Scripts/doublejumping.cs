using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doublejumping : MonoBehaviour
{
    public RigidbodyConstraints constraints;
    public bool freezePosition;
    private Rigidbody2D rgdBody;
    public float jumpHeight;
    private void Awake()
    {
        rgdBody = GetComponent<Rigidbody2D>();
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
                rgdBody.AddForce(Vector2.up * 800);
                isJumping = 1;
            }

            else if (isJumping == 1)
            {
                rgdBody.velocity = Vector3.zero;
                rgdBody.AddForce(Vector2.up * 800);
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