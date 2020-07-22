using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{

    [SerializeField] int currentWeapon = 0; //Starting with...


    void Start()
    {
        SetActiveWeapon();
    }

    void Update()
    {
        int prevWeapon = currentWeapon;

        GetKeyInput();
        GetScrollInput();

        if(prevWeapon != currentWeapon)
        {
            SetActiveWeapon();
        }
    }

    private void GetKeyInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = 2;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GetComponent<PauseMenu>().PauseMenuPressed();
        }
    }

    private void GetScrollInput()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0) //Upwards wheel
        {
            if (currentWeapon >= transform.childCount - 1)  //Starts from beginning
            {
                currentWeapon = 0;
            }
            else
            {
                currentWeapon++;
            }

        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0) //Downwards from
        {
            if (currentWeapon <= 0)  //Goes to last weapon
            {
                currentWeapon = transform.childCount - 1;
            }
            else
            {
                currentWeapon--;
            }

        }
    }

    private void SetActiveWeapon()
    {
        int weaponIndex = 0;

        foreach (Transform weapon in transform) 
        {
            if (weaponIndex == currentWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }
    }


}
