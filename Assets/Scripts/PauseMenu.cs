using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] Canvas pauseMenuCanvas;


    public static bool GameIsPaused = false;
  

    private void Start()
    {
        pauseMenuCanvas.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuCanvas.enabled = false;
        Time.timeScale = 1;
        GameIsPaused = false;
        FindObjectOfType<WeaponSwitch>().enabled = true;
        FindObjectOfType<Weapon>().enabled = true;
        Cursor.visible = false;
    }

    public void Pause()
    {
        pauseMenuCanvas.enabled = true;
        Time.timeScale = 0;
        GameIsPaused = true;
        FindObjectOfType<WeaponSwitch>().enabled = false;
        FindObjectOfType<Weapon>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}