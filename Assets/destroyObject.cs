using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{
    bool ready = true;
    float timer;
    [SerializeField] SpriteRenderer sP;
    [SerializeField] Color32 c1;
    [SerializeField] Color32 c2;
    // Start is called before the first frame update
    void Start()
    {
        ready = true;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColour();
        timer += 1 * Time.deltaTime;
    //    Debug.Log("Destroy timer: " + timer.ToString());
        if (!ready)
        {
         //   Debug.Log(ready);
            if (timer >= 5)
            {
                ready = true;
         //       Debug.Log(ready);
            }
        }
        else if (ready)
        {
            return;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (ready)
            {
                Destroy(collision.gameObject);
                ready = false;
                timer = 0;
            }

        }
    }

    void ChangeColour()
    {
        if (ready)
        {
            sP.color = c1;
        }
        else if (!ready)
        {
            sP.color = c2;
        }
    }
}
