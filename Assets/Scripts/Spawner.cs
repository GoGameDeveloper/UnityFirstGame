using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstecle;
    public Vector3 spawnPosition;
    public float spawnTimer = 2.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject()
    {
        Instantiate(obstecle);
    }

}
