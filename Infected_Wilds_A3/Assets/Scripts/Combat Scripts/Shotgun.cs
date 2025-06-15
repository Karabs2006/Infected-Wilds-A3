using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shotgun : MonoBehaviour
{
    public PlayerShooting playerShooting;

    public GameObject dialogue;

    public bool foundShotgun;

    [SerializeField] private AudioClip reload;
    [SerializeField] private AudioSource pickup;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogue.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.CompareTag("Player"))
        {
            //Time.timeScale = 0f;
            //dialogue.SetActive(true);
            foundShotgun = true;
            Destroy(gameObject);
            pickup.PlayOneShot(reload);
            
        }

    }

    public void Next()
    {
        Time.timeScale = 1f;
        dialogue.SetActive(false);
       
       
    }
}
