/*
Title: Random Enemy Spawner - Unity 2D Tutorial
Author: PekkeDev
Date: 03 September 2019
Code version: N/A
Availability: https://www.youtube.com/watch?v=yjYSsRiA0do
*/

using UnityEngine;

public class HealthSpawner : MonoBehaviour
{

    public GameObject healthPrefab; 
    public float spawnInterval = 2f; // How often to spawn Health Kits
    public int maxHealthKits = 10;
    //public float spawnRange = 5f; // Area range around the spawner
    private int healthKitsSpawned = 0;
    //Assign the enemy prefab in Inspector
    public float spawnRadius = 10f;
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnInterval); 
    }
    
    void SpawnEnemy()
    {
        if (healthKitsSpawned >= maxHealthKits)
            return;

        
        for (int i = 0; i < maxHealthKits; i++)
        {
            // Generate a random position within a circle
            Vector2 spawnPosition = (Vector2)transform.position + Random.insideUnitCircle * spawnRadius;

            // Spawn the Health Kit
            Instantiate(healthPrefab, spawnPosition, Quaternion.identity);
        }
    }
    
    
}
