using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Vector3 originalLocation;
    float spawnTime;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        originalLocation = new Vector3(transform.position.x, transform.position.y, -1);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime = Random.Range(1, 10);
        timer += 1 * Time.deltaTime;
        if (timer > 10f)
        {
            spawnEnemies();
            timer = 0;
        }
    }

    void spawnEnemies()
    {
        if (enemy != null)
        {
            Instantiate(enemy, originalLocation, Quaternion.identity);
            Debug.Log("Birth for the enemy!");
        }

    }
}
