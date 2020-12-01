using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject snowball;
    public Camera mainCam;
    public GameObject snowman;
    public ParticleSystem snowParticleHitGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
         
            snowball.SetActive(false);
       
            


    }
      
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       


        }
    }





