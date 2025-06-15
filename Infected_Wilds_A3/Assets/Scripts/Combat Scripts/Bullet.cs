using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Bullet : MonoBehaviour
{   
    //This code is used to destroy both the bullets and the enemy when the collide with each other

    public float speed = 15f;
    public int damage = 25;
    public float lifetime = 2f; // Auto-destroy after time
    private Rigidbody2D rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.up * speed;
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        // Check if we hit an enemy
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        // Destroy bullet on any collision (except player)
        if (!hitInfo.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    
    }
}
