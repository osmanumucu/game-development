using Unity.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] clouds;

    private float zCloudSpawn = 20f;

    private float startDelay = 1.0f;

    private float cloudSpawnTime = 2.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnClouds", startDelay, cloudSpawnTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Spawning clouds
    void SpawnClouds()
    {
        float randomY = Random.Range(5.0f, 7.5f); // The range wherein the clouds are going to be spawned
        int randomIndex = Random.Range(0, clouds.Length); // Taking a random index

        Vector3 spawnPos = new Vector3(-1.98f, randomY, zCloudSpawn); // The coordinates where the clouds will be spawned

        Instantiate(clouds[randomIndex], spawnPos, clouds[randomIndex].gameObject.transform.rotation); // 
    }
}
