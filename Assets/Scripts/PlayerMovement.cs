using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D myRB2d;
    float horizontal;
    float vertical;
    float moveLimiter = 0.6f;
    [SerializeField] float moveSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        myRB2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0)
        {
            horizontal *= moveLimiter;
            vertical += moveLimiter;
        }
       myRB2d.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
    }
}
