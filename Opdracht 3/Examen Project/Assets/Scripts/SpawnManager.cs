using Unity.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] clouds;

    private float zCloudSpawn = 20f;

    private float startDelay = 1.0f;

    private float cloudSpawnTime = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnClouds", startDelay, cloudSpawnTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnClouds()
    {
        float randomY = Random.Range(5.0f, 7.5f);
        int randomIndex = Random.Range(0, clouds.Length);

        Vector3 spawnPos = new Vector3(-1.98f, randomY, zCloudSpawn);

        Instantiate(clouds[randomIndex], spawnPos, clouds[randomIndex].gameObject.transform.rotation);
    }
}
