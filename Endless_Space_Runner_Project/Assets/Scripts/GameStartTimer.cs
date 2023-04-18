using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameStartTimer : MonoBehaviour
{
    public TMP_Text timerText;
    public GameObject particle;
    public GameObject pauseButton;

    // Start is called before the first frame update
    void Start()
    {
        
        Time.timeScale = 0;
        ResumeTimer();
    }

    public void ResumeTimer()
    {
        StartCoroutine(StartTimer());
        timerText.gameObject.SetActive(true);
        timerText.text = "3";
    }


    private IEnumerator StartTimer()
    {
        yield return new WaitForSecondsRealtime(1);
        timerText.text = "2";
        yield return new WaitForSecondsRealtime(1);
        timerText.text = "1";
        yield return new WaitForSecondsRealtime(1);
        timerText.gameObject.SetActive(false);
        particle.SetActive(true);
        pauseButton.SetActive(true);
        Time.timeScale = 1;
    }
}
