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
    public GameObject shotgunInv;
    public GameObject pistolInv;
    public GameObject shotgunPrefab;
    public GameObject pistolPrefab;
    public PlayerShooting playerShooting;
    public Shotgun shotgun;
    public Transform spawnPoint;
    public Transform originalSpawnPoint;

    void Start()
    {
        shotGunPlayer.SetActive(false);
        pistolInv.SetActive(true);
        shotgunInv.SetActive(false);
    }

    void Update()
    {
        if (shotgun.foundShotgun)
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                //When NUM1 is pressed, the Pistol object in the canvas is initiated, with its respective bullet count
                
                pistolInv.SetActive(true);
                shotgunInv.SetActive(false);
                shotGunPlayer.SetActive(false);
                playerShooting.bulletPrefab = pistolPrefab;
                playerShooting.isPistolActive = true;
                playerShooting.bulletSpawnPoint = originalSpawnPoint;
                playerShooting.count.text = $"{playerShooting.pistolAmmo}";
             
            }

            if (Input.GetKey(KeyCode.Alpha2))
            {
                //When NUM2 is pressed, the Shotgun object in the canvas is initiated, with its respective bullet count

                shotgunInv.SetActive(true);
                pistolInv.SetActive(false);
                shotGunPlayer.SetActive(true);
                playerShooting.bulletPrefab = shotgunPrefab;
                playerShooting.isPistolActive = false;
                playerShooting.bulletSpawnPoint = spawnPoint;
                playerShooting.count.text = $"{playerShooting.shotgunBullets}";
            
            }
        }

    }
}
