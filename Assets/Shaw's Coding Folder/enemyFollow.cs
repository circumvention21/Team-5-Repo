using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public GameObject Player;
    public float enemySpeed;
    bool Check;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Check)
        {
                Vector2 PlayerPos = new Vector2(Player.transform.position.x, 0);

                

                transform.position = Vector3.MoveTowards(transform.position, PlayerPos, enemySpeed * Time.deltaTime);
            }
            
        }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger.Equals(false) && collision.gameObject.tag.Equals("Player") | collision.gameObject.tag.Equals("snowBall"))
        {
            Check = true;
        }


    }
}

