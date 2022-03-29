using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Vector3 originalLocation;
    float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemies());
        originalLocation = new Vector3(transform.position.x, transform.position.y, -1);
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator spawnEnemies()
    {
        spawnTime = Random.Range(1, 10);
        yield return new WaitForSeconds(spawnTime);
        Instantiate(enemy, originalLocation, Quaternion.identity);
    }
}
