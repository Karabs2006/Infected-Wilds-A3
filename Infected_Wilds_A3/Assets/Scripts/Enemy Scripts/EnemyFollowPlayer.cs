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

    //This code is used to make enemies follow the player once they come close enough to trigger the following behavior.
    //Reference: https://www.youtube.com/watch?v=D0tjzZEwaAg
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        float distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);

    if (distanceToPlayer <= followRadius)
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
    }
}
