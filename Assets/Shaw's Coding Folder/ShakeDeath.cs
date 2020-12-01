using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeDeath : MonoBehaviour
{
    public Camera mainCam;
    public ParticleSystem enemyExplosion;


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
