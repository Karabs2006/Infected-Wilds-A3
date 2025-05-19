/* 
        This code is used for the shooting mechanic in the game. The bullet fires when the Left Mouse button is clicked 
        and shoots from where the player is facing.

        Reference: https://www.youtube.com/watch?v=Ryd_b8QDQ8A&t=233s

        */


using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [Header("Shooting Settings")]
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float fireRate = 0.5f;

    [Header("Audio Settings")]
    [SerializeField] private AudioClip shootSound;
    [SerializeField] private float shootVolume = 0.5f;

    private float nextFireTime;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    private void Shoot()
    {
        // Create bullet
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, transform.rotation);
        bullet.GetComponent<Rigidbody2D>().linearVelocity = transform.up * bulletSpeed;

        // Play shoot sound
        if (shootSound != null)
        {
            audioSource.PlayOneShot(shootSound, shootVolume);
        }
    }
}