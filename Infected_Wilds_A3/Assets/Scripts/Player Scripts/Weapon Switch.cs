using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class WeaponSwitch : MonoBehaviour
{
    public Sprite oldGun;
    public Sprite newGun;

    [SerializeField]
    private Image currentGun;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Alpha1))
        {
            currentGun.sprite = oldGun;
            
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            currentGun.sprite = newGun;
        }

        
    }
}
