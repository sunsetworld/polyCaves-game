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
}
