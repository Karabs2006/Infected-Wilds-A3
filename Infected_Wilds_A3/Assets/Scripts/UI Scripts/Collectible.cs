using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Collectible : MonoBehaviour
{
    
   void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.CompareTag("Player"))
        {
            PlayerShooting playerShooting = trigger.GetComponent<PlayerShooting>();

           
                if (playerShooting.isPistolActive && playerShooting.pistolAmmo < 64)
                {
                    playerShooting.pistolAmmo += 4;
                    if (playerShooting.pistolAmmo > 64)
                        playerShooting.pistolAmmo = 64;

                    playerShooting.count.text = $"{playerShooting.pistolAmmo}";
                    Destroy(gameObject);
                }
                else if (!playerShooting.isPistolActive && playerShooting.shotgunBullets < 32)
                {
                    playerShooting.shotgunBullets += 2;
                    
                    if (playerShooting.shotgunBullets > 32)
                    playerShooting.shotgunBullets = 32;

                    playerShooting.count.text = $"{playerShooting.shotgunBullets}";
                    Destroy(gameObject);
                }
            
        }
    }
}
