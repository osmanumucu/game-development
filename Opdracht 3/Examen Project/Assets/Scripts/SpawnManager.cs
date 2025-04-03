using Unity.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] clouds;

    public GameObject gold;

    public GameObject skull;

    private float zSpawn = 20f;

    private float startDelay = 1.0f;

    private float cloudSpawnTime = 2.5f;
    private float goldSpawnTime = 5.0f;
    private float skullSpawnTime = 7.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnClouds", startDelay, cloudSpawnTime);
        InvokeRepeating("SpawnGold", startDelay, goldSpawnTime);
        InvokeRepeating("SpawnSkull", startDelay, skullSpawnTime);



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

        Vector3 spawnPos = new Vector3(-1.98f, randomY, zSpawn); // The coordinates where the clouds will be spawned

        Instantiate(clouds[randomIndex], spawnPos, clouds[randomIndex].gameObject.transform.rotation); // 
    }

    void SpawnGold()
    {
        float randomY = Random.Range(-4.5f, 6.5f); // The range wherein the clouds are going to be spawned

        Vector3 spawnPos = new Vector3(0, randomY, zSpawn); // The coordinates where the gold will be spawned

        Instantiate(gold, spawnPos, gold.gameObject.transform.rotation);
    }

        void SpawnSkull()
    {
        float randomY = Random.Range(-4.5f, 6.5f); // The range wherein the clouds are going to be spawned

        Vector3 spawnPos = new Vector3(0, randomY, zSpawn); // The coordinates where the skull will be spawned

        Instantiate(skull, spawnPos, skull.gameObject.transform.rotation);
    }
}
