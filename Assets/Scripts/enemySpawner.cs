using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Vector3 originalLocation;
    Vector3 newLocation;
    float spawnTime;
    float timer;
    int timerValue;
    float tX;
    float tY;
    // Start is called before the first frame update
    void Start()
    {
        tX = Random.Range(-6.5f, 6.5f);
        tY = Random.Range(-3.5f, 3.5f);
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
            newLocation = new Vector3(tX, tY, transform.position.y);
            Instantiate(enemy, newLocation, Quaternion.identity);
         //   Debug.Log("Birth for the enemy!");
        }

    }
}
