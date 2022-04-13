using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectingTreasure : MonoBehaviour
{
    [SerializeField] int score = 0; // Initializes score int and sets it to 0.
    [SerializeField] AudioClip collectSFX;
    [SerializeField] treasureSpawner tS;
    // Start is called before the first frame update
    void Start()
    {
        tS.GetComponent<treasureSpawner>();
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
            tS.AddCollectedTotal();
            AudioSource.PlayClipAtPoint(collectSFX, transform.position);
            Destroy(other.gameObject);
            score += 1;
        }
    }

    public int GetScore()
    {
        return score;
        // Returns the value of score. 
    }

    public void ReduceScore()
    {
        score -= 10;
    }
}
