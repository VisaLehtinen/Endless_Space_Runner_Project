using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameStartTimer : MonoBehaviour
{
    public TMP_Text timerText;
    public GameObject particle;

    // Start is called before the first frame update
    void Start()
    {
        
        Time.timeScale = 0;
        StartCoroutine(StartTimer());
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
        Time.timeScale = 1;
    }
}
