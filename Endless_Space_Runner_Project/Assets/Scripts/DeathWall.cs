using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathWall : MonoBehaviour
{

    public ObstacleSpawner obstacleSpawner;
    public ObstacleSpawner obstacleSpawner2;
    public ObstacleSpawner obstacleSpawner3;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            obstacleSpawner.enemyCount--;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Obstacle2"))
        {
            obstacleSpawner2.enemyCount--;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Obstacle3"))
        {
            obstacleSpawner3.enemyCount--;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Collectible"))
        {
            obstacleSpawner.enemyCount--;
            Destroy(other.gameObject);
        }
    }
}
