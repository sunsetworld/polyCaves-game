using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killPlayer : MonoBehaviour
{
    [SerializeField] int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("This should only run if the player is colliding with the enemy");
            reduceLives();
            Debug.Log("This should take 1 enemy off the game.");
            Destroy(other.gameObject);
        }
    }

    private void reduceLives()
    {
        Debug.Log("This should take a life off the player.");
        lives -= 1;
        
        if (lives <= 0)
        {
            Debug.Log("This should then kill the player.");
            lives = 0;
            Invoke("death", 0.5f);
        }
    }

    private void death()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public int GetLives()
    {
        return lives;
    }

}
