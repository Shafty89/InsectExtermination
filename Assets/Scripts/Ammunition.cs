using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammunition : MonoBehaviour
{
    [SerializeField] int ammoCount = 10;

    public int GetCurrentAmmo()
    {
        return ammoCount;
    }

    public void DecreaseAmmo()
    {
        ammoCount--;
    }

}
