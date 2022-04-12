using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Vector3 originalLocation;
    float spawnTime;
    float timer;
    int timerValue;
    // Start is called before the first frame update
    void Start()
    {
        originalLocation = new Vector2(transform.position.x, transform.position.y);
        if (SceneManager.GetActiveScene().name == "L1")
        {
            timerValue = 4;
        }
        if (SceneManager.GetActiveScene().name == "L2")
        {
            timerValue = 5;
        }
        if (SceneManager.GetActiveScene().name == "L3")
        {
            timerValue = 6;
        }
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime = Random.Range(1, 10);
        timer += 1 * Time.deltaTime;
        if (timer >= timerValue)
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
         //   Debug.Log("Birth for the enemy!");
        }

    }
}
