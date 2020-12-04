using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public GameObject Life3;
    public GameObject Life2;
    public GameObject Life1;
    public int lifePoints = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        Life2.SetActive(false);
        Life1.SetActive(false);
    }

   
        // Update is called once per frame
        void Update()
    {
        
  
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            lifePoints -= 1;
            Debug.Log("You have hit the player");

            if (lifePoints == 2)
            {

                Life3.SetActive(false);
                Life2.SetActive(true);

                Heart3.SetActive(false);


            }

            if (lifePoints == 1)
            {

                Life2.SetActive(false);
                Life1.SetActive(true);
                Heart2.SetActive(false);

            }

            if (lifePoints == 0)
            {

                Heart1.SetActive(false);

            }


        }

        

        }
    }

