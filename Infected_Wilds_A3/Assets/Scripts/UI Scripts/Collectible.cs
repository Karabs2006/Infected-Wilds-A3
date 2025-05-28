using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Collectible : MonoBehaviour
{
    
    public TMP_Text count;
    
    void OnTriggerEnter2D(Collider2D trigger)
    {
        // Check if we hit an enemy
        PlayerShooting playerShooting = trigger.GetComponent<PlayerShooting>();


        if (trigger.CompareTag("Player"))
        {
            count.text = $"{playerShooting.bulletCount + 2}";
            Destroy(gameObject);

        }
    }
}
