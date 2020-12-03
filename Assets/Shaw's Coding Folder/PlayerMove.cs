using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    public float movementSpeed;
    public float jumpHeight;
    public bool isGrounded;
    public int dashDirection = 1;
    public float dashForce;
    public bool LeftShift;
    public bool isDashing;
    public float StartDashTime;
    public float CurrentDashTime;

    void Start()
    {

    }

    void Update()
    {


        Jump();

        if (Input.GetKey(KeyCode.LeftShift))
        {
            movementSpeed = 180;
            LeftShift = true;
        }
        else
        {
            movementSpeed = 120;
            LeftShift = false;
        }

        if (!isGrounded && LeftShift == true)
        {
            CurrentDashTime = StartDashTime;
            rb.velocity = Vector2.zero;
            
            Debug.Log("You have pressed space and Left shift");
            isDashing = true;
        }
        else
        {
            isDashing = false;
        }

        if (isDashing)
        {

            rb.velocity = transform.right * dashDirection * dashForce;

            rb.AddForce(new Vector3(dashForce, 0));

            CurrentDashTime -= 1;

            if(CurrentDashTime <= 0)
            {
                isDashing = false;

            }

        }


        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed, rb.velocity.y);

    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            rb.AddForce(new Vector2(0, jumpHeight));
            Debug.Log("Jump");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Grounded"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}
