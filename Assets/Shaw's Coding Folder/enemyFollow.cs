using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public GameObject Player;
    public float enemySpeed;
    bool Check;
    public float fireRate = 2f;
    float NextFire = Time.time;
    public GameObject EnemyBullet;
    // Start is called before the first frame update
    void Start()
    {

    }
    void CheckIfTimeToFire()
    {

        if (Time.time > NextFire)
        {
            Instantiate(EnemyBullet, transform.position, Quaternion.identity);
            NextFire = Time.time + fireRate;
            Debug.Log("Fire");

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Check)
        {
            CheckIfTimeToFire();
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

