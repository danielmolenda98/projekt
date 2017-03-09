using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doublejumping : MonoBehaviour
{

    public float jumpHeight;
    private int isJumping = 2;
    //private bool isJumping2 = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Jumping Section
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isJumping == 2 )
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 1000);
                isJumping = 1;
            }
            else if (isJumping == 1)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 800);
                isJumping = 0;
            
            }

        }
    }

    //this bit is to check if the object that collided with it has the ground tag
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isJumping = 2;
            //isJumping2 = false;
        }
    }
}