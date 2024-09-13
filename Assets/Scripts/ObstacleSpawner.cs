using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;
    [SerializeField] float xPos;
    [SerializeField] float yPos;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), spawnInterval, spawnInterval);
    }

    void SpawnObstacle()
    {
        float randomX = Random.Range(-xPos, xPos);

        float randomY = Random.Range(-yPos, yPos);

        Vector2 randomPos = new Vector2(randomX, randomY);

        Instantiate(obstaclePrefab, randomPos, Quaternion.identity);
    }
}
