using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject[] obstaclePrefabs;
    public Vector3 center;
    public Vector3 size;
    [SerializeField]
    public int enemyCount;
    public int enemyCountMax;
    public bool spawnCoolDown;
    public float spawnTime;

    private void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        
        if (enemyCount > enemyCountMax -1)
        {
            StopAllCoroutines();
            return;
        }
        else
        {
            Debug.Log("Spawning");
            StartCoroutine(SpawnTimer());
        }
        
    } 

    public void Spawn()
    {
        spawnCoolDown = true;
        StartCoroutine(SpawnTimerCooldown());
        enemyCount++;
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

        int randomIndex = Random.Range(0, obstaclePrefabs.Length);
        if (this.CompareTag("Spawner1"))
        {
            Instantiate(obstaclePrefabs[randomIndex], pos, Quaternion.identity);
        }
        else
        {
            Instantiate(obstaclePrefab, pos, Quaternion.identity);
        }

        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }

    private IEnumerator SpawnTimer()
    {
        yield return new WaitForSeconds(spawnTime);
        if (!spawnCoolDown)
        {
            Spawn();
        }
       
    }

    private IEnumerator SpawnTimerCooldown()
    {
        yield return new WaitForSeconds(spawnTime);
        spawnCoolDown = false;

    }
}

