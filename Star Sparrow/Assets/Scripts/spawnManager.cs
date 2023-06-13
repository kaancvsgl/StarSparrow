using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    objectSpawner objectspawner;

    void Start()
    {
        objectspawner = GetComponent<objectSpawner>();
    }

    
    void Update()
    {
        objectspawner.spawnObstacles();
    }

   
}
