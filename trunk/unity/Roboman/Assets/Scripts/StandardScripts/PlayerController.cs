using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float heroSpeed;
    Animator anim;
    public Rigidbody2D Rigidbody;
    bool dirToRight = true;
    public float jumpForce;
    public bool grounded;
    [SerializeField] private bool airControl = false;
    [Range(0, 1)][SerializeField] private float crouchSpeed = .36f;

    void Start()
    {
        anim = GetComponent<Animator>();
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        Rigidbody.velocity = new Vector2(horizontalMove * heroSpeed, Rigidbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.AddForce(new Vector2(0f, jumpForce));
            anim.SetTrigger("Jump");
        }

        anim.SetFloat("speed", Mathf.Abs(horizontalMove));
    }

    public void Move(float move, bool crouch, bool jump)
    {
        if (grounded || airControl)
        {
            move = (crouch ? move * crouchSpeed : move);
            anim.SetFloat("Speed", Mathf.Abs(move));
            Rigidbody.velocity = new Vector2(move * heroSpeed, Rigidbody.velocity.y);

            if (move < 0 && dirToRight /*facingRight*/)
            {
                Flip();
            }

            if (move > 0 && !dirToRight)
            {
                Flip();
            }
        }
	}

    void Flip()
    {
        dirToRight = !dirToRight;
        Vector3 heroScale = gameObject.transform.localScale;
        heroScale.x *= -1;
        gameObject.transform.localScale = heroScale;
    }
}
