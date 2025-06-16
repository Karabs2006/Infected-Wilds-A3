using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;


public class Melee : MonoBehaviour
{
    public Animator anim;
    public int hitDamage;
    public int EnemyHealth = 100;
    
    
    
    void OnTriggerEnter2D(Collider2D trigger)
        {   // This code explains how much damage an enemy takes/ how many shots it takes to destroy an enemy
           
            Enemy enemy = trigger.gameObject.GetComponent<Enemy>();
            
            bool attacked = anim.GetBool("IsAttack");

            if(trigger.gameObject.name == "Wolf" && attacked)
            {
                EnemyHealth -= hitDamage; 

            } 

            if (EnemyHealth <= 0)
            {
                Destroy(enemy.gameObject);
                
            }

            if(trigger.gameObject.name == "Wolf(Clone)" && attacked)
            {
                EnemyHealth -= hitDamage; 

            } 
            if (EnemyHealth <= 0)
            {
                Destroy(enemy.gameObject);
            
            }

            


}


}
