using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectingTreasure : MonoBehaviour
{
    [SerializeField] int score = 0;
    [SerializeField] GameObject[] treasure;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        loadNextLevel();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Treasure")
        {
            Destroy(other.gameObject);
            score += 1;
        }
    }

    public int GetScore()
    {
        return score;
    }

    private void loadNextLevel()
    {
        if (score >= treasure.Length)
        {
<<<<<<< HEAD
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private static void lNL()
    {
    }
=======
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
>>>>>>> parent of 8acc9fa (:()
}
