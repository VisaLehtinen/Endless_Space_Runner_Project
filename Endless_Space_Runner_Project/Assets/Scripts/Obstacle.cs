using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Obstacle : MonoBehaviour
{
    public int damage;
    public float speed;
    

    private CinemachineImpulseSource impulseSource;
    public ObstacleSpawner obstacleSpawner;
    

    
    private void Start()
    {
        impulseSource = GetComponent<CinemachineImpulseSource>();
        obstacleSpawner = FindObjectOfType<ObstacleSpawner>();
        if (this.tag == "Obstacle")
        {
            obstacleSpawner = GameObject.FindGameObjectWithTag("Spawner1").GetComponent<ObstacleSpawner>();
        }

        if (this.tag == "Obstacle2")
        {
            obstacleSpawner = GameObject.FindGameObjectWithTag("Spawner2").GetComponent<ObstacleSpawner>();
        }

        if (this.tag == "Obstacle3")
        {
            obstacleSpawner = GameObject.FindGameObjectWithTag("Spawner3").GetComponent<ObstacleSpawner>();
        }
    }
    

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CameraShakeManager.instance.CameraShake(impulseSource);
            other.GetComponent<PlayerStats>().health -= damage;
            Debug.Log("Collided with enemy");
            obstacleSpawner.enemyCount--;
            Destroy(gameObject);
        }
        
        
    }

    

    
}
