using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    [SerializeField] float gameTimer = 100;
    [SerializeField] GameObject player;
    [SerializeField] GameObject enemies;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        gameTimer -= Time.deltaTime;
        if (gameTimer <= 0)
        {
            Destroy(player);
            var enem = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemies in enem)
            {
                Destroy(enemies);
            }
<<<<<<< HEAD
            reloadGame();
=======
>>>>>>> parent of 9683977 (Some changes (Time for a 0.2 build?))
        }
    }
    public float GetgameTimer()
    {
        return gameTimer;

    }
}
