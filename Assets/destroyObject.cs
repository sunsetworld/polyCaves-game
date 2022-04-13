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
    [SerializeField] Sprite s1;
    [SerializeField] Sprite s2;
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
            if (timer >= 5)
            {
                ready = true;
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Treasure")
        {
            other.transform.position = new Vector3(other.transform.position.x + 3, other.transform.position.y + 3, other.transform.position.z);
        }
    }

    void ChangeColour()
    {
        if (ready)
        {
            sP.sprite = s1;
        }
        else if (!ready)
        {
            sP.sprite = s2;
        }
    }
}
