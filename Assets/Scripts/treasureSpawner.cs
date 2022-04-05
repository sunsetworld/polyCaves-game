using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureSpawner : MonoBehaviour
{
    [SerializeField] Vector3 originalLocation;
    [SerializeField] GameObject treasure;
    [SerializeField] Vector3 newLocation;
    float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        spawnTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime += 1 * Time.deltaTime;
        if (spawnTime > 7)
        {
            spawnTreasure();
            spawnTime = 0;
            spawnTime += 1 * Time.deltaTime;
        }
    }

    void spawnTreasure()
    {
        newLocation = new Vector2(transform.position.x, transform.position.y);
        Instantiate(treasure, newLocation, Quaternion.identity);
    }

}
