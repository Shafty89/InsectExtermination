using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammunition : MonoBehaviour
{

    [SerializeField] AmmoSlot[] ammoSlots;

    [System.Serializable]
    private class AmmoSlot
    {
        public AmmoType ammoType;
        public int ammoCount;
    }

    //public int GetCurrentAmmo()
    //{
    //    return ammoCount;
    //}

    //public void DecreaseAmmo()
    //{
    //    ammoCount--;
    //}

}
