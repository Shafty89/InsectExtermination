using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] Canvas pauseMenuCanvas;


    private void Start()
    {
        pauseMenuCanvas.enabled = false;
    }

    public void PauseMenuPressed()
    {
        pauseMenuCanvas.enabled = true;
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitch>().enabled = false;     //Prevents from switching weapons upon pausing
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

}
