using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Collectible : MonoBehaviour
{
    
    public TMP_Text count;

    void Start()
    {
        GameObject ammoText = GameObject.FindWithTag("AmmoText");
        
        if (ammoText != null)
        {
            count = ammoText.GetComponent<TMP_Text>();
        }

        else
        {
            Debug.LogWarning("AmmoText not found!");
        }
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        // Check if we hit an enemy
        PlayerShooting playerShooting = trigger.GetComponent<PlayerShooting>();

       

        if (trigger.CompareTag("Player") && playerShooting.bulletCount < 64)
        {
            count.text = $"{playerShooting.bulletCount += 2}";
            Destroy(gameObject);

        }
        else 
        {
            Destroy(gameObject);

        }
    }
}
