using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureSpawner : MonoBehaviour
{
    [SerializeField] Vector3 originalLocation;
    [SerializeField] GameObject treasure;
    float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnTreasure());
        originalLocation = new Vector3(transform.position.x, transform.position.y, -1);
        // 7, 4, -1
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator spawnTreasure()
    {
        Instantiate(treasure, originalLocation, Quaternion.identity);
        spawnTime = Random.Range(1, 2);
        originalLocation = new Vector3(Random.Range(-7, 7), Random.Range(-4, 4), -1);  
        yield return new WaitForSeconds(spawnTime);
        Instantiate(treasure, originalLocation, Quaternion.identity);
    }

    void startSpawning()
    {
        StartCoroutine(spawnTreasure());
    }
}
