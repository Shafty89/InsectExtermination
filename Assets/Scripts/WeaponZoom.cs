using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{

    [SerializeField] Camera fpsCam;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;

    bool zoomToggle = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomToggle == false)
            {
                zoomToggle = true;
                fpsCam.fieldOfView = zoomedInFOV;
            }
            else
            {
                zoomToggle = false;
                fpsCam.fieldOfView = zoomedOutFOV;
            }
        }
    }

}
