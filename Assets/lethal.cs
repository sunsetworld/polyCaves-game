using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lethal : MonoBehaviour
{
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        if (timer > 10)
        {
            Destroy(gameObject);
        }
    }
}
