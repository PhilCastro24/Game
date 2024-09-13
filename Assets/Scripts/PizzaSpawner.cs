using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaSpawner : MonoBehaviour
{
    [SerializeField] GameObject PizzaPrefab;

    public float spawnInterval = 2;

    void Start()
    {
        InvokeRepeating(nameof(SpawnPizza), spawnInterval, spawnInterval);
    }

    void Update()
    {
    }

    void SpawnPizza()
    {
        float randomX = Random.Range(20, 30);
        float randomY = Random.Range(15, 20);
        Vector2 randomPos = new Vector2(randomX, randomY);
        Instantiate(PizzaPrefab, randomPos, Quaternion.identity);
    }
}
