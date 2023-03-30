using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class PlayerStats : MonoBehaviour
{
    public int health;
    public int collectibleCount;
    public TMP_Text countText;
    public TMP_Text healthText;
    public GameObject gameOverPanel;
    public Animator gameOverAnimator;
    public GameObject particle;
    public GameObject spawner;

    private void Update()
    {
        countText.text = ": " + collectibleCount;
        healthText.text = "X " + health;
        if (health <= 0)
        {
            spawner.SetActive(false);
            Instantiate(particle, transform.position, Quaternion.identity);
            gameOverAnimator.SetTrigger("GameOver");
            Destroy(gameObject);
            //Time.timeScale = 0;
        }
    }
}
