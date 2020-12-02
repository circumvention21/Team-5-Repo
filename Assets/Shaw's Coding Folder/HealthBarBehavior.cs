using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBarBehavior : MonoBehaviour
{
    public Slider slider;
    public Color low;
    public Color high;
    public Vector3 Offset;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SetHealth(float health, float MaxHealth)
    {

        slider.gameObject.SetActive(health < MaxHealth);
        slider.value = health;
        slider.maxValue = MaxHealth;
        
    }

    // Update is called once per frame
        void Update()
    {
        
    }


   

}
