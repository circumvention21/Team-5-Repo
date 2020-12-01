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


    void Start()
    {

    }

    void Update()
    {

        Jump();

        if (Input.GetKey(KeyCode.LeftShift))
        {
            movementSpeed = 180;
            Debug.Log("Sprint");
        }
        else
        {
            movementSpeed = 120;
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

    private void OnTriggerStay2D(Collider2D other)
    {
        isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isGrounded = false;
    }
}
