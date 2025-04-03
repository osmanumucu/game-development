using Unity.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // All game objects that can be assigned with the inspector
    public GameObject[] clouds;
    public GameObject gold;
    public GameObject skull;
    public GameObject rock;
    public GameObject heal;

    // The z coordinate where all the objects will be spawned
    private float zSpawn = 20f;

    // Start delay before spawning anything
    private float startDelay = 1.0f;

    // The time how often the objects will be spawned
    private float cloudSpawnTime = 2.5f;
    private float goldSpawnTime = 5.0f;
    private float skullSpawnTime = 7.0f;
    private float rockSpawnTime = 3.0f;
    private float healSpawnTime = 10.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnClouds", startDelay, cloudSpawnTime);
        InvokeRepeating("SpawnGold", startDelay, goldSpawnTime);
        InvokeRepeating("SpawnSkull", startDelay, skullSpawnTime);
        InvokeRepeating("SpawnRock", startDelay, rockSpawnTime);
        InvokeRepeating("SpawnHeal", startDelay, healSpawnTime);

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
        float randomY = Random.Range(-4.5f, 6.5f); // The range wherein the golds are going to be spawned
        Vector3 spawnPos = new Vector3(0, randomY, zSpawn - 1); // The coordinates where the gold will be spawned
        Instantiate(gold, spawnPos, gold.gameObject.transform.rotation);
    }

    void SpawnSkull()
    {
        float randomY = Random.Range(-4.5f, 6.5f); // The range wherein the skulls are going to be spawned
        Vector3 spawnPos = new Vector3(0, randomY, zSpawn - 2); // The coordinates where the skull will be spawned
        Instantiate(skull, spawnPos, skull.gameObject.transform.rotation);
    }

    void SpawnRock()
    {
        float randomY = Random.Range(-4.5f, 6.5f); // The range wherein the rocks are going to be spawned
        Vector3 spawnPos = new Vector3(0, randomY, zSpawn - 3); // The coordinates where the rock will be spawned
        Instantiate(rock, spawnPos, rock.gameObject.transform.rotation);
    }

    void SpawnHeal()
    {
        float randomY = Random.Range(-4.5f, 6.5f); // The range wherein the heals are going to be spawned
        Vector3 spawnPos = new Vector3(0, randomY, zSpawn - 4); // The coordinates where the heal will be spawned
        Instantiate(heal, spawnPos, heal.gameObject.transform.rotation);

    }
}
