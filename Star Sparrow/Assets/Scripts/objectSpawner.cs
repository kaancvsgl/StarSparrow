using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSpawner : MonoBehaviour
{
    private int lastSpawn = 45;
    private int spawnInterval = 50;

    public List<GameObject> obstacles;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void spawnObstacles()
    {
        lastSpawn += spawnInterval;

        if (Random.Range(0, 1) == 0)
        {
            GameObject obstacle = obstacles[Random.Range(0, obstacles.Count)];
            var clone = Instantiate(obstacle, new Vector3(Random.Range(-20f,20f), 0f, lastSpawn),obstacle.transform.rotation);

        }
    }
}
