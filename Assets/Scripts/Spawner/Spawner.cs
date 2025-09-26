using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject _enemyPrefab; // Drag and drop the _enermy prefab here
    public float spawnInterval = 2f; // Time between each spawn
    public int maxEnemies = 5; // Maximum number of enemies to spawn

    private int currentEnemyCount = 0;
    private float nextSpawnTime;

    void Start()
    {
        nextSpawnTime = Time.time + spawnInterval;
    }

    void Update()
    {
        if (currentEnemyCount < maxEnemies && Time.time >= nextSpawnTime)
        {
            SpawnEnemy();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnEnemy()
    {
        Instantiate(_enemyPrefab, transform.position, transform.rotation);
        currentEnemyCount++;
    }
}