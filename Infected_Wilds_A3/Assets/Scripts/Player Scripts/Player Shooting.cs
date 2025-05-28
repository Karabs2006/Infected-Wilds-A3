using TMPro;
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

    public TMP_Text count;
    public int bulletCount = 64;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void Start()
    {
        count.text = $"{bulletCount}";
    }


    private void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= nextFireTime && bulletCount>0)
        {
            Shoot();
            bulletCount--;
            count.text = $"{bulletCount}";
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