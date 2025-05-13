using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{

    [SerializeField]
    private RectTransform healthBar;

    private float maxHealth;

    public void ShrinkBar(float amount)
    {
        // Just shrink the width by a fixed amount
        healthBar.sizeDelta = new Vector2(healthBar.sizeDelta.x - amount, healthBar.sizeDelta.y);
    }
}


