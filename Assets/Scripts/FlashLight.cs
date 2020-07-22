using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    [SerializeField] float lightDecay = .1f;
    [SerializeField] float angleDecay = 1f;
    [SerializeField] float minimumAngle = 40f;

    Light playerLight;

    private void Start()
    {
        playerLight = GetComponent<Light>();
    }

    private void Update()
    {
        DecreaseLightAngle();
        DecreaseLightIntensity();
    }

    public void RestoreLightAngle(float restoreAngle)
    {
        playerLight.spotAngle = restoreAngle;
    }
    public void AddLightIntensity(float addIntensity)
    {
        playerLight.intensity += addIntensity;
    }

    private void DecreaseLightIntensity()
    {
        playerLight.intensity -= lightDecay * Time.deltaTime;
    }

    private void DecreaseLightAngle()
    {
        if (playerLight.spotAngle <= minimumAngle)
        {
            return;
        } else
        {
            playerLight.spotAngle -= angleDecay * Time.deltaTime;
        }
        
    }
}
