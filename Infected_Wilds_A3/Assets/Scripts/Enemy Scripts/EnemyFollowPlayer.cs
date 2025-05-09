/*
Title: How to have an Enemy follow the Player in Unity Tutorial
Author: Game Dev By Kaupenjoe
Date: 01 September 2023
Code version: N/A
Availability: https://www.youtube.com/watch?v=D0tjzZEwaAg
*/


using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class EnemyFollowPlayer : MonoBehaviour
{
    public float speed = 1.5f;
    public float followRadius = 5f;
    public GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        // Check if the player still exists before accessing it
        if (player != null)
        {
            float distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);

            if (distanceToPlayer <= followRadius)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
            }
        }
        else
        {
            // Optionally re-acquire the player if it's been destroyed and respawned
            player = GameObject.FindWithTag("Player");
        }
    }
}
