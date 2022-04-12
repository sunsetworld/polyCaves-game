using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killPlayer : MonoBehaviour
{
    int lives;
    [SerializeField] AudioSource pAS;
    [SerializeField] AudioClip hitSound;
    [SerializeField] AudioClip deathSound;
    int l1 = 3;
    int l2 = 4;
    int l3 = 5;
    [SerializeField] CollectingTreasure cT;
    // Start is called before the first frame update
    void Start()
    {
        // cT.GetComponent<CollectingTreasure>();
        if (SceneManager.GetActiveScene().name == "L1")
        {
            lives = l1;
        }
        if (SceneManager.GetActiveScene().name == "L2")
        {
            lives = l2;
        }
        if (SceneManager.GetActiveScene().name == "L3")
        {
            lives = l3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RestoreLife();
        }
    }

    private void RestoreLife()
    {
        if (cT.GetScore() > 10)
        {
            lives += 1;
            cT.ReduceScore();
        }
    }

    private void OnMouseDown()
    {
        RestoreLife();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            // Debug.Log("This should only run if the player is colliding with the enemy");
            reduceLives();
           //  Debug.Log("This should take 1 enemy off the game.");
            Destroy(collision.gameObject);
        }
    }

    private void reduceLives()
    {
       // Debug.Log("This should take a life off the player.");
        lives -= 1;
        if (lives > 0)
        {
            AudioSource.PlayClipAtPoint(hitSound, Camera.main.transform.position, 1);
        }

        if (lives <= 0)
        {

            AudioSource.PlayClipAtPoint(deathSound, Camera.main.transform.position, 1);
           // Debug.Log("This should then kill the player.");
            lives = 0;
            Invoke("death", 0.5f);
        }
    }

    private void death()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(5);
    }

    public int GetLives()
    {
        return lives;
    }

    private void AddLives()
    {
        lives += 1;
    }

}
