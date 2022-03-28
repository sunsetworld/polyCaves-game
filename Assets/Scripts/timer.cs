using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    [SerializeField] float gameTimer = 100;
    [SerializeField] GameObject player;
    [SerializeField] GameObject enemies;
    [SerializeField] GameManager gm;
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
            reloadGame();
        }
    }
    public float GetgameTimer()
    {
        return gameTimer;

    }

    private void reloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
