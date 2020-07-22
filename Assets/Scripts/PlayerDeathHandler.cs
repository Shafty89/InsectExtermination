using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;


    private void Start()
    {
        gameOverCanvas.enabled = false;
    }

    public void PlayerDeath()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitch>().enabled = false;     //Prevents from switching weapons upon dying
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

}
