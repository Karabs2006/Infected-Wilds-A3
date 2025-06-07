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
    [SerializeField] private AudioClip deathSound;
    [SerializeField] private AudioSource audioSource;
    public new ParticleSystem particleSystem;


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
        EnemyHealth -= damage;
        if (EnemyHealth <= 0)
        {
            Die();
            score.AddScore(enemyScore);
            audioSource.PlayOneShot(deathSound);

        }
    }

    void Die()
    {
            Destroy(gameObject);
    }
}

