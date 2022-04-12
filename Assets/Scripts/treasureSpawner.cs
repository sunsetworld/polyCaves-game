using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class treasureSpawner : MonoBehaviour
{
    [SerializeField] Vector3 newLocation;
    [SerializeField] GameObject treasure;
    float spawnTime;

    int timerValue;
    bool spawn = true;




    // Start is called before the first frame update
    void Start()
    {
        spawnTime = 0;
        if (SceneManager.GetActiveScene().name == "L1")
        {
            timerValue = 6;
        }
        if (SceneManager.GetActiveScene().name == "L2")
        {
            timerValue = 8;
        }
        if (SceneManager.GetActiveScene().name == "L3")
        {
            timerValue = 10;
        }

    }



    // Update is called once per frame
    void Update()
    {
        timerForSpawning(timerValue);
    }

    private void timerForSpawning(int sceneTime)
    {
        spawnTime += 1 * Time.deltaTime;
        if (spawnTime >= sceneTime)
        {
            if (spawn == true)
            {
                spawnTreasure();
                spawnTime = 0;
                spawnTime += 1 * Time.deltaTime;
            }

        }
    }

    void spawnTreasure()
    {
        newLocation = new Vector2(transform.position.x, transform.position.y);
        Instantiate(treasure, newLocation, Quaternion.identity);
    }

    public void toggleSpawn()
    {
        if (spawn == true)
        {
            spawn = false;
        }
        else if (spawn == false)
        {
            spawn = true;
        }
    }

}
