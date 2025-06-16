using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shotgun : MonoBehaviour
{
    public bool foundShotgun; //Checks if player found Shotgun
    [SerializeField] private AudioClip reload;
    [SerializeField] private AudioSource pickup;

    void OnTriggerEnter2D(Collider2D trigger) //Allows player to switch bewteen weapons & access Shotgun Ammo
    {
        if (trigger.CompareTag("Player"))
        {
            foundShotgun = true;
            pickup.PlayOneShot(reload);
            Destroy(gameObject);
        }

    }

    
}
