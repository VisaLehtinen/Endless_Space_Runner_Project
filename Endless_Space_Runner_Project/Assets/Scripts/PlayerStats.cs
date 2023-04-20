using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


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
    public GameObject pauseButton;
    public AudioSource collectibleSource;
    public AudioSource enemySource;
    

    private void Update()
    {
        countText.text = ": " + collectibleCount;
        healthText.text = "X " + health;
        if (health <= 0)
        {
            
            spawner.SetActive(false);
            pauseButton.SetActive(false);
            Instantiate(particle, transform.position, Quaternion.identity);
            gameOverAnimator.SetTrigger("GameOver");
            Destroy(gameObject);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectible") || other.CompareTag("Heart"))
        {
            collectibleSource.Play();
        }
        if (other.CompareTag("Obstacle") || other.CompareTag("Obstacle2") || other.CompareTag("Obstacle3"))
        {
            enemySource.Play();
        }
    }
}
