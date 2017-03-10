using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doublejumping : MonoBehaviour
{
    private int isJumping = 2;

    private Rigidbody rb;

    // Update is called once per frame
    void Update()
    {

        //Jumping Section
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isJumping == 2)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 800);
                isJumping = 1;
            }

            else if (isJumping == 1)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 500);
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