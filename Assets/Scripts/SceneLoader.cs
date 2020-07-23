using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
        Time.timeScale = 1;
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void PlayAgainFromStart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }


    public void ReloadGame()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
