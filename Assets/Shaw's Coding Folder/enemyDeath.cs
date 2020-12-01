using UnityEngine;

public class enemyDeath : MonoBehaviour
{
    private int enemyHealth = 30;
    public GameObject enemy;
    public ParticleSystem enemyExplosion;
    public Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyExplosion.IsAlive(true))
        {
           
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("snowBall")){

            enemyHealth -= 10;

            if (enemyHealth <= 0)
            {
                enemyExplosion.transform.position = new Vector2(enemy.transform.position.x - 0.6f, enemy.transform.position.y - 0.8f);
                enemy.SetActive(false);
                enemyExplosion.Play();
              

            }

        }
    }
    public System.Collections.IEnumerator shake(float duration, float magnitude)
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
