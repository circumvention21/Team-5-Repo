using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehavior : MonoBehaviour
{
    public float MoveSpeed = 7f;
    public GameObject Player;
    public Rigidbody2D rb;
    public Vector2 MoveDirection;
    public GameObject Bullet;
    public GameObject PlayerHit;
    public Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        MoveDirection = (Player.transform.position * 3 - transform.position).normalized * MoveSpeed;
        rb.velocity = new Vector2(MoveDirection.x, MoveDirection.y);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            

            Instantiate(PlayerHit, Player.transform.position, Quaternion.identity);



        }

        }
    }

