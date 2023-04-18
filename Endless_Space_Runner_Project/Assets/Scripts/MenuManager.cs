using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public string levelSceneName;
    public string mainMenuSceneName;
    public bool isPaused;
    public GameObject pausePanel;
    public GameStartTimer gameStartTimer;

    public void LoadScene()
    {
        StartCoroutine(FadeToScene());
    }

    public void Retry()
    {
        SceneManager.LoadScene(levelSceneName);
    }

    public void LoadMainMenuScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(mainMenuSceneName);
    }

    public void Pause()
    {
        if (!isPaused)
        {
            pausePanel.SetActive(true);
            isPaused = true;
            Time.timeScale = 0;
        }
    }


    public void Resume()
    {
        if (isPaused)
        {
            isPaused = false;
            gameStartTimer.ResumeTimer();
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    private IEnumerator FadeToScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(levelSceneName);
    }
}
