using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectingTreasure : MonoBehaviour
{
    [SerializeField] int score = 0; // Initializes score int and sets it to 0.

    //  [SerializeField] List<GameObject> treasure;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       // loadNextLevel();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Treasure")
            // If the player collides with the treasure.
        {
            Destroy(other.gameObject);
            // Destorys the treasure.
            // treasure.Remove(other.gameObject);
            score += 1;
        }
    }

    public int GetScore()
    {
        return score;
        // Returns the value of score. 
    }


    // private void loadNextLevel()
    // {
    //     if (treasure.Count == 0)
    //     {
    //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //     }
    // }
}
