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
            

            StartCoroutine(shake(0.2f, 0.13f));

            Instantiate(PlayerHit, Player.transform.position, Quaternion.identity);



        }

        }

    public IEnumerator shake(float duration, float magnitude)
        {

            Vector3 originalPos = mainCam.transform.localPosition;

            float elapsed = 0.0f;

            while (elapsed < duration)
            {
                float x = Random.Range(-1f, 1f) * magnitude;
                float y = Random.Range(-1f, 1f) * magnitude;

                mainCam.transform.localPosition = new Vector3(x, y, originalPos.z);

                elapsed += Time.deltaTime;

                yield return null;
            }
            mainCam.transform.localPosition = originalPos;
        }
    }

