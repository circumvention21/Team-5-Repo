using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleHitFollow : MonoBehaviour
{
    public GameObject snowball;
    public ParticleSystem snowParticleHitGround;
    public bool triggered;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        snowParticleHitGround.transform.position = new Vector2(snowball.transform.position.x, snowball.transform.position.y);
        if (triggered)
        {
            {
                
                Instantiate(snowParticleHitGround, snowball.transform.position, snowball.transform.rotation);
                snowParticleHitGround.Play();

                Debug.Log("Snow hit ground");



                

            }
        }
    }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag.Equals("Ground"))
        {
            triggered = true;
        }
        else
        {
            triggered = false;
        }
            
        }
    } 
  

