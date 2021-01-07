using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShake : MonoBehaviour
{
    public Camera mainCam;
    public Rigidbody2D rb;
    public int knockbackStrength;
    public GameObject Enemy;
    Vector3 originalPos;
    public AudioSource HitSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
            Vector2 forceVector = collision.transform.position - Enemy.transform.position;
            forceVector.y = 0;
            if (collision.gameObject.tag.Equals("snowBall"))
            {
                rb.AddForce(forceVector * -knockbackStrength, ForceMode2D.Impulse);
            HitSound.Play();

          
           
        }
    }
}

