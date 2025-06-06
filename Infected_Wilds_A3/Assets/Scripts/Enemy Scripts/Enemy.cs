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
    public int hitDamage;
    public Score score;

    public int enemyScore = 0;

    public DeathParticles deathParticles;

    [SerializeField] private AudioClip deathSound;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private GameObject deathParticlePrefab;





    void Start()
    {
        if (score == null)
        {
            GameObject ScoreObj = GameObject.FindWithTag("Score");
            if (ScoreObj != null)
            {
                score = ScoreObj.GetComponent<Score>();
            }
            else
            {
                Debug.LogWarning("Score not found in scene!");
            }
        }

        if (deathParticles == null)
        {
            GameObject DeathParticles = GameObject.FindWithTag("DeathPrt");
            if (DeathParticles != null)
            {
                deathParticles = DeathParticles.GetComponent<DeathParticles>();
            }
            else
            {
                Debug.LogWarning("DeathPrts not found in scene!");
            }
        }
        

        if (audioSource == null)
        {
            GameObject Death = GameObject.FindWithTag("WolfDeath");
            if (Death != null)
            {
                audioSource = Death.GetComponent<AudioSource>();
            }
            else
            {
                Debug.LogWarning("Sound not found in scene!");
            }
        }
    }



    void OnTriggerEnter2D(Collider2D trigger)
    {   // This code explains how much damage an enemy takes/ how many shots it takes to destroy an enemy
        Bullet bulletScript = trigger.gameObject.GetComponent<Bullet>();

        if (trigger.gameObject.name == "Bullet")
        {
            EnemyHealth -= bulletScript.damage;

        }
        if (EnemyHealth == 0)
        {
            Destroy(gameObject);
        }
            
            if (trigger.CompareTag("Melee")) // Make sure your enemy GameObjects are tagged "Enemy"
        {

            TakeDamage(20);
        }
            

}

public void TakeDamage(int damage)
    {
        EnemyHealth-= damage;
        if (EnemyHealth <= 0)
        {
            Die();
            score.AddScore(enemyScore);
            audioSource.PlayOneShot(deathSound);

        }
    }

    void Die()
    {
        // Instantiate particles at this enemy's position
    GameObject deathEffect = Instantiate(deathParticlePrefab, transform.position, Quaternion.identity);
    
    // Optional: destroy particles after they're done
    ParticleSystem ps = deathEffect.GetComponent<ParticleSystem>();
    if (ps != null)
    {
        Destroy(deathEffect, ps.main.duration + ps.main.startLifetime.constantMax);
    }

    // Destroy enemy
    Destroy(gameObject);

    }

    

}

