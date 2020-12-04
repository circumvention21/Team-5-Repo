 using UnityEngine;
using UnityEngine.UI;

public class enemyDeath : MonoBehaviour
{
    public int enemyHealth = 40;
    public GameObject enemy;
    public int damage = 10;
    public ParticleSystem enemyExplosion;
    public Camera mainCam;
    public Slider HealthBar;
    public GameObject SliderNoActive;
    public Vector3 Offset;
    public GameObject EnemyHit;
    
    // Start is called before the first frame update
    void Start()
    {
        SliderNoActive.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        SliderNoActive.transform.position = Camera.main.WorldToScreenPoint(enemy.transform.position + Offset);
        if (enemyExplosion.IsAlive(true))
        {
           
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("snowBall"))
        {
            SliderNoActive.SetActive(true);
            enemyHealth -= damage;
            HealthBar.value = enemyHealth;
            Instantiate(EnemyHit, transform.position, Quaternion.identity);
        

          

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
