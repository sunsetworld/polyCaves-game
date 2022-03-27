using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            reduceLives();
            Destroy(other.gameObject);
        }
    }

    private void reduceLives()
    {
        lives -= 1;
        
        if (lives <= 0)
        {
            lives = 0;
            Invoke("death", 0.2f);
        }
    }

    private void death()
    {
        Destroy(gameObject);
    }

    public int GetLives()
    {
        return lives;
    }
}
