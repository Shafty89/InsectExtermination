using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickups : MonoBehaviour
{
    [SerializeField] float restoreAngle = 90f;
    [SerializeField] float addIntensity = 1f;

    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponentInChildren<FlashLight>().RestoreLightAngle(restoreAngle);
            other.GetComponentInChildren<FlashLight>().AddLightIntensity(addIntensity);
            Destroy(gameObject);
        }
    }
}
