using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{

    public Slider slider;

     void Start()
{
    if (slider == null)
    {
        GameObject sliderObj = GameObject.FindWithTag("Slider");
        if (sliderObj != null)
        {
            slider = sliderObj.GetComponent<Slider>();
        }
        else
        {
            Debug.LogWarning("HealthSlider not found in scene!");
        }
    }
}


    public void SetHealth(float health)
    {

        slider.value = health;
    }

    public void Damage(int damage)
    {
        slider.value -= damage;
    }

    
}


