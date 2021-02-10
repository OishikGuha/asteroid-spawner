using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float timeDelay;
    [Space]
    public GameObject[] objectsToSpawn;
    public GameObject[] spawners;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Length)], spawners[Random.Range(0, spawners.Length)].transform);
        yield return new WaitForSeconds(timeDelay);
        StartCoroutine("Spawn");
    }
}
