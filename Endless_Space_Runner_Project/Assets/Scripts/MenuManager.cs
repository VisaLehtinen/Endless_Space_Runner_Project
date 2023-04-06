using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public string levelSceneName;
    public string mainMenuSceneName;

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
        SceneManager.LoadScene(mainMenuSceneName);
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
