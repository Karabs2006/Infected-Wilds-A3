using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HealthKit : MonoBehaviour
{
    float MedKit = 20;
    public HealthBarUI healthBarUI;

    [System.Obsolete]
    void Start()
    {
        if (healthBarUI == null)
        {
            healthBarUI = GameObject.FindObjectOfType<HealthBarUI>();
        }
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {   // This code is used to used to increase the Player's Health once they collide with the Health Kit

        Player playerScript = trigger.gameObject.GetComponent<Player>();

        if (trigger.gameObject.name == "Player" && playerScript != null && playerScript.PlayerHealth < 100f)
        {
            // If the Player collides with a Health Kit (or vice versa), the Player's health will increase by 10.
            // The Health Kit is destroyed immediately after colliding with the player/ after the Player has used it.

            playerScript.PlayerHealth += MedKit;

            healthBarUI.SetHealth(playerScript.PlayerHealth);
            Destroy(gameObject);

        }

        if (trigger.gameObject.name == "Player" && playerScript.PlayerHealth == 100f)
        {
            Destroy(gameObject);
        }

    }


}
