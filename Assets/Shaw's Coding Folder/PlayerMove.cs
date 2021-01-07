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
    public bool isDashing;
    public float StartDashTime;
    public float CurrentDashTime;
    public float MovX;
    public int alreadyDashed;
    public Animator ani;
    public AudioSource JumpSound;

    void Start()
    {
      
    }

    void Update()
    {

        MovX = Input.GetAxis("Horizontal");

        Jump();

        if (MovX == 0)
        {

            ani.SetBool("isStill", true);

        }
        else
        {

            ani.SetBool("isStill", false);

        }


        if (Input.GetKey(KeyCode.LeftShift))
        {

            movementSpeed = 320;

        }
        else
        {

            movementSpeed = 120;

        }
    
        

            ani.SetFloat("Speed", MovX);

        

        rb.velocity = new Vector2(MovX* Time.deltaTime * movementSpeed, rb.velocity.y);

    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            JumpSound.Play();
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
