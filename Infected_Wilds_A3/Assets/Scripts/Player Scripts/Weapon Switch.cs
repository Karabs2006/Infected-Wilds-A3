using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class WeaponSwitch : MonoBehaviour
{
    public Sprite oldGun;
    public Sprite newGun;
    public SpriteRenderer currentPlayer;

    public GameObject shotGunPlayer;
    public Sprite playerPistol;
    public Sprite playerShotgun;

    [SerializeField]
    private Image currentGun;
    public GameObject shotgunPrefab;
    public GameObject pistolPrefab;
    public PlayerShooting playerShooting;
    public Shotgun shotgun;
    public Transform spawnPoint;
    public Transform originalSpawnPoint;


    // Update is called once per frame

    void Start()
    {
        shotGunPlayer.SetActive(false);
    }
    void Update()
    {
        if (shotgun.foundShotgun)
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                currentGun.sprite = oldGun;
                shotGunPlayer.SetActive(false);
                playerShooting.bulletPrefab = pistolPrefab;
                playerShooting.isPistolActive = true;
                playerShooting.bulletSpawnPoint = originalSpawnPoint;
                playerShooting.count.text = $"{playerShooting.pistolAmmo}";
             
            }

            if (Input.GetKey(KeyCode.Alpha2))
            {
                currentGun.sprite = newGun;
                shotGunPlayer.SetActive(true);
                playerShooting.bulletPrefab = shotgunPrefab;
                playerShooting.isPistolActive = false;
                playerShooting.bulletSpawnPoint = spawnPoint;
                playerShooting.count.text = $"{playerShooting.shotgunBullets}";
            
            }
        }

    }
}
