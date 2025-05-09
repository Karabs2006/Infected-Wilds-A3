/*
Title: title of program/source code
Author: author(s) names
Date: date accessed
Code version: code version
Availability: where it's located (url)
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{   
  
    public int EnemyHealth = 100;

    public int PlayerDamage = 25;


    
    void OnTriggerEnter2D(Collider2D trigger)
        {   // This code explains how much damage an enemy takes/ how many shots it takes to destroy an enemy
            Bullet bulletScript = trigger.gameObject.GetComponent<Bullet>();

            if(trigger.gameObject.name == "Bullet")
            {
                EnemyHealth -= bulletScript.damage; 

            } 
            if(EnemyHealth == 0)
            {
                Destroy(gameObject);
            }

}

public void TakeDamage(int damage)
    {
        EnemyHealth-= damage;
        if (EnemyHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}

