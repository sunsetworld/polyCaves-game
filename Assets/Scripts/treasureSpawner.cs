using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class treasureSpawner : MonoBehaviour
{
    Vector3 newLocation;
    [SerializeField] GameObject treasure;
    GameObject[] tS;
    float spawnTime;

    int timerValue;
    bool spawn;

    int treasureLimit;
    int treasureAmount;

    float tX;
    float tY;

    


    // Start is called before the first frame update
    void Start()
    {
        spawn = false;
        treasureAmount = 0;
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
            treasureLimit = 10;
        }

    }

    public void AddCollectedTotal()
    {
        treasureAmount += 1;
    }



    // Update is called once per frame
    void Update()
    {
        Debug.Log(treasureAmount.ToString());
        spawnTreasure();
        ToggleSpawning();
    }



    void spawnTreasure()
    {
        if (spawn)
        {
            for (int i = 0; i < treasureLimit; i++)
            {
                float tX = Random.Range(-5f, 5f);
                float tY = Random.Range(-2f, 2f);
                newLocation = new Vector2(tX, tY);
                Instantiate(treasure, newLocation, Quaternion.identity);
            }
            spawn = false;
        }

    }

    void ToggleSpawning()
    {
        if (treasureAmount >= treasureLimit)
        {
            spawn = true;
            treasureAmount = 0;
        }
    }


}
