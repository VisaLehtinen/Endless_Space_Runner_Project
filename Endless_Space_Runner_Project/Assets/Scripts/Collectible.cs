using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collectible : MonoBehaviour
{
    public PlayerStats playerStats;
    public ObstacleSpawner obstacleSpawner;
    public float speed;
    
    

    private void Start()
    {
        playerStats = FindObjectOfType<PlayerStats>();
        obstacleSpawner = GameObject.FindGameObjectWithTag("Spawner1").GetComponent<ObstacleSpawner>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerStats.collectibleCount++;
            obstacleSpawner.enemyCount--;
            Destroy(gameObject);
        }
    }
}
