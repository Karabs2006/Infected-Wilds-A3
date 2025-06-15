using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class WeaponSwitch : MonoBehaviour
{
    public Sprite oldGun;
    public Sprite newGun;
    public SpriteRenderer currentPlayer;
    public Sprite playerPistol;
    public Sprite playerShotgun;

    [SerializeField]
    private Image currentGun;
    public GameObject shotgunPrefab;
    public GameObject pistolPrefab;
    public PlayerShooting playerShooting;
    public Shotgun shotgun;

    // Update is called once per frame
    void Update()
    {
        if (shotgun.foundShotgun)
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                currentGun.sprite = oldGun;
                currentPlayer.sprite = playerPistol;
                playerShooting.bulletPrefab = pistolPrefab;


            }

            if (Input.GetKey(KeyCode.Alpha2))
            {
                currentGun.sprite = newGun;
                currentPlayer.sprite = playerShotgun;
                playerShooting.bulletPrefab = shotgunPrefab;

            }
        }

        
    }
}
