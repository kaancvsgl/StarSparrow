using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject obstacle;
    public float minX, maxX, minY, maxY;
    public float timeBetweenSpawn;
    private float spawnTime;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Time.time> spawnTime)
        {
            spawn();
            spawnTime += Time.time + timeBetweenSpawn;
        }
    }

    void spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
