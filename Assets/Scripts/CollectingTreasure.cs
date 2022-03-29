using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectingTreasure : MonoBehaviour
{
    [SerializeField] int score = 0;

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
        {
            Destroy(other.gameObject);
            // treasure.Remove(other.gameObject);
            score += 1;
        }
    }

    public int GetScore()
    {
        return score;
    }


    // private void loadNextLevel()
    // {
    //     if (treasure.Count == 0)
    //     {
    //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //     }
    // }
}
