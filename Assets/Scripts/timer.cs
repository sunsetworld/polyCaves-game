using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    [SerializeField] float gameTimer = 100;
    [SerializeField] GameObject player;
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
        }
    }
    public float GetgameTimer()
    {
        return gameTimer;
    }
}
