using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform ShootPoint;
    public Camera cam;
    public Vector2 lookDirection;
    public float angle;
    public float bulletCap = 15;
    public float ReloadTime = 1.5f;
    public float BulletSpeed = 10f;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        

        if (MousePos.x < 0)
        {
            sr.flipX = true;
        }
        else
        {

            sr.flipX = false;
        }


        
        if (Input.GetButtonDown("Fire1"))
        {

            Shoot();

        }
    }


    public void Shoot()
    {

        GameObject bullet = Instantiate(bulletPrefab, ShootPoint.position, ShootPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(ShootPoint.up * BulletSpeed, ForceMode2D.Impulse);
   



    }
}

