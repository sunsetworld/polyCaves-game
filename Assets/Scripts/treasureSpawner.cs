using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class treasureSpawner : MonoBehaviour
{
    [SerializeField] Vector3 newLocation;
    [SerializeField] GameObject treasure;
    GameObject[] tS;
    float spawnTime;

    int timerValue;
    bool spawn = false;

    int treasureLimit;

    float tX;
    float tY;

    


    // Start is called before the first frame update
    void Start()
    {
        tX = Random.Range(-6.5f, 6.5f);
        tY = Random.Range(-3.5f, 3.5f);

        spawnTime = 0;
        if (SceneManager.GetActiveScene().name == "L1")
        {
            timerValue = 6;
            treasureLimit = 5;
        }
        if (SceneManager.GetActiveScene().name == "L2")
        {
            timerValue = 8;
            treasureLimit = 8;
        }
        if (SceneManager.GetActiveScene().name == "L3")
        {
            timerValue = 10;
            treasureLimit = 13;
        }

    }



    // Update is called once per frame
    void Update()
    {

       timerForSpawning(timerValue);
        Debug.Log(spawn);

    }



    private void timerForSpawning(int sceneTime)
    {
        spawnTime += 1 * Time.deltaTime;
        if (spawnTime >= sceneTime)
        {
            if (spawn == true)
            {
                spawnTreasure();
                spawn = false;
                spawnTime = 0;
                spawnTime += 1 * Time.deltaTime;
            }
        }
    }

    void spawnTreasure()
    {
        float tX = Random.Range(-6.5f, 6.5f);
        float tY = Random.Range(-3.5f, 3.5f);
        newLocation = new Vector2(tX, tY);
        Instantiate(treasure, newLocation, Quaternion.identity);
    }

    public void toggleSpawnOn()
    {
        spawn = true;
    }


}
