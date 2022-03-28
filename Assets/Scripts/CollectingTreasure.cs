using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingTreasure : MonoBehaviour
{
    [SerializeField] int score = 0;
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
<<<<<<< HEAD

    private void loadNextLevel()
    {
        if (score >= treasure.Length)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

=======
>>>>>>> parent of 9683977 (Some changes (Time for a 0.2 build?))
}
