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
                StartCoroutine(shake(0.26f, 0.15f));
            
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

            mainCam.transform.localPosition  = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }
        mainCam.transform.localPosition = originalPos;
    }
}

