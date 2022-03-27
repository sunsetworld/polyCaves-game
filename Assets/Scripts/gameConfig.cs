using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameConfig : MonoBehaviour
{
    [SerializeField] int scoreMultiplier = 1;
    // The multiplier of score as definied by settings for lives, playerSpeed and enemySpeed. 
    [SerializeField] int lives = 1;
    // If the player chooses more lives, the multiplier will decrease.
    [SerializeField] int playerSpeed = 1;
    // If the player chooses a faster player, the multiplier will decrease.
    [SerializeField] int enemySpeed = 1;
    // If the player chooses faster enemies, the multiplier will increase. 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void multiplier()
    {
        livesMultiplier();
        playerSpeedMultiplier();
        enemySpeedMultiplier();
    }

    private void livesMultiplier()
    {
        if (lives == 3)
        {
            scoreMultiplier += 1;
        }
        else if (lives == 2)
        {
            scoreMultiplier += 2;
        }
        else if (lives == 1)
        {
            scoreMultiplier += 3;
        }
    }

    private void playerSpeedMultiplier()
    {
        if (playerSpeed == 3)
        {
            scoreMultiplier += 1;
        }
        else if (playerSpeed == 2)
        {
            scoreMultiplier += 2;
        }
        else if (playerSpeed == 1)
        {
            scoreMultiplier += 3;
        }
    }

    private void enemySpeedMultiplier()
    {
        if (enemySpeed == 1)
        {
            scoreMultiplier += 1;
        }
        else if (enemySpeed == 2)
        {
            scoreMultiplier += 2;
        }
        else if (enemySpeed == 3)
        {
            scoreMultiplier += 3;
        }


    }
}
