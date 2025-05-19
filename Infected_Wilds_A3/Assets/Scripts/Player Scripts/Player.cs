/*
Title: Rotate Character To Mouse Position (Beginner Friendly Tutorial)
Author: Piir
Date: 26 June 2021
Code version: N/A
Availability: https://www.youtube.com/watch?v=9_i6S_rDZuA
*/

/*
Title: How to Spawn Objects at Different Directions in Unity 2D!
Author: Kozmobot Games
Date: 27 January 2025
Code version: N/A
Availability: https://www.youtube.com/watch?v=9_i6S_rDZuA
*/

/*
Title: How to Make Camera Follow In UNITY 2D
Author: Anup Prasad
Date: 30 October 2020
Code version: N/A
Availability: https://www.youtube.com/watch?v=FXqwunFQuao&list=PLmwQNimN3PLb5BtAm0u5M0qS3IOKpnmAC&index=3
*/

/*
Title: How to make a HEALTH BAR in Unity!
Author: Brackeys
Date: 09 February 2020
Code version: N/A
Availability: https://www.youtube.com/watch?v=BLfNP4Sc_iA
*/



using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public Rigidbody2D _rigidbody;
    public GameObject Player1;
    public float _speed;

    public float PlayerHealth = 100;
    int damage = 10;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed;
    private Animator _animator;

    public HealthBarUI healthBarUI;

    public Collider2D Hitbox;

   

    private void Awake()
    {
        _animator = GetComponent<Animator>();

    }

    void Update()
    {
        MovePlayer(); //This is code used in order to rotate the player according to the mouse position

        /* 

        Reference: https://www.youtube.com/watch?v=9_i6S_rDZuA

        */

        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Mathf.Abs(Camera.main.transform.position.z);
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.up = direction.normalized;

        /* 
        This code is used for the shooting mechanic in the game. The bullet fires when the Left Mouse button is clicked 
        and shoots from where the player is facing.

        Reference: https://www.youtube.com/watch?v=Ryd_b8QDQ8A&t=233s

        */

       
    }

    IEnumerator AttackAnim()
    {
        _animator.SetBool("IsAttack", true);
        Hitbox.enabled = true;
        yield return new WaitForSeconds(0.5f); 
        _animator.SetBool("IsAttack", false);
        Hitbox.enabled = false;
    }


    void MovePlayer()
    {//This is the method used for player movement.

        Vector3 movePosition = Vector3.zero;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            movePosition.y += 1; //The Player moves upwards
            _animator.SetBool("IsMoving", true);

        }

        else
        {
            _animator.SetBool("IsMoving", false);
        }


        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            movePosition.y -= 1; //The Player moves downwards
        }


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            movePosition.x -= 1; //The Player moves left
        }


        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            movePosition.x += 1; //The Player moves right
        }


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            movePosition.x -= 1; //The Player moves left
        }

        if (Input.GetKey(KeyCode.E))
        {
            StartCoroutine(AttackAnim());
            //The Player moves left
        }



        Player1.transform.position += movePosition.normalized * Time.deltaTime;

        _rigidbody.linearVelocity = movePosition.normalized * _speed;
        _animator.SetBool("IsMoving", movePosition != Vector3.zero); //Script for Movement. When the player releases a movement key, the movement animation will stop playing


    }

    void OnCollisionEnter2D(Collision2D collision)//This is a basic script for enemy attacks
    {
        if (collision.gameObject.name == "Wolf")//If the Player has collided with an Enemy (or vice versa), the Player's health will decrease.
        {
            PlayerHealth = PlayerHealth - damage;
            healthBarUI.Damage(damage);

        }

        else if (PlayerHealth <= 0)//When the Player's health reaches 0, they will be given the option to Restart or Quit
        {
            SceneManager.LoadScene("GameOverScreen");
        }


        if (collision.gameObject.name == "Wolf(Clone)")//If the Player has collided with an Enemy (or vice versa), the Player's health will decrease.
        {
            PlayerHealth = PlayerHealth - damage;
            healthBarUI.Damage(damage);

            if (PlayerHealth > 0)
            {


            }

            else if (PlayerHealth <= 0)//When the Player's health reaches 0, they will be given the option to Restart or Quit
            {
                SceneManager.LoadScene("GameOverScreen");
            }

        }

        if (collision.gameObject.name == "Bear")
        {
            PlayerHealth = PlayerHealth - 50;
            healthBarUI.Damage(50);



            if (PlayerHealth > 0)
            {

            }

            else if (PlayerHealth <= 0) //When the Player's health reaches 0, they will be given the option to Restart or Quit
            {
                SceneManager.LoadScene("GameOverScreen");
            }


        }

        if (collision.gameObject.name == "Bear(Clone)")
        {
            PlayerHealth = PlayerHealth - 50;
            healthBarUI.Damage(50);



            if (PlayerHealth > 0)
            {


            }

            else if (PlayerHealth <= 0) //When the Player's health reaches 0, they will be given the option to Restart or Quit
            {
                SceneManager.LoadScene("GameOverScreen");

            }


        }



    }





}
