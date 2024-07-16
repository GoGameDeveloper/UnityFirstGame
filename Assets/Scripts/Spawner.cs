using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstecle;
    public Vector3 spawnPosition;
    public Quaternion spawnRotation = Quaternion.identity;
    public float spawnTimer = 2.0f;
    public float deleteTimer = 6f;
    List<GameObject> obsteclesList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I got to start function");
        spawnPosition = transform.position;
        StartCoroutine(SpawnObjectAtIntervals());
        StartCoroutine(DestroyObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator DestroyObject() 
    {
        yield return new WaitForSeconds(deleteTimer);
        Destroy(obsteclesList[0]);
    }

    IEnumerator SpawnObjectAtIntervals()
    {
        Debug.Log("I got to SpawnObjectAtIntervals function");
        while (true)
        {
            yield return new WaitForSeconds(spawnTimer);
            SpawnObject();
        }
    }


    void SpawnObject()
    {
        GameObject fallObject = Instantiate(obstecle, spawnPosition, spawnRotation);
        obsteclesList.Add(fallObject);
        Rigidbody rb = fallObject.AddComponent<Rigidbody>();
        rb.mass = 10f;
        fallObject.transform.position = new Vector3(fallObject.transform.position.x + Random.Range(-15, 15),
                                                    fallObject.transform.position.y + Random.Range(1, 3),
                                                    fallObject.transform.position.z + Random.Range(-15, 15)
                                                    );

        Debug.Log("I got to spawn function");
    }

}
