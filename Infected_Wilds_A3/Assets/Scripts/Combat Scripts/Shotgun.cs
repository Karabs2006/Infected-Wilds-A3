using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shotgun : MonoBehaviour
{
    
    public bool foundShotgun;
    [SerializeField] private AudioClip reload;
    [SerializeField] private AudioSource pickup;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.CompareTag("Player"))
        {
            foundShotgun = true;
            pickup.PlayOneShot(reload);
            Destroy(gameObject);
        }

    }

    
}
