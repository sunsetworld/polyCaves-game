using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float movingSpeed;

    private Transform target;
    private Transform enemyTarget;

    [SerializeField] GameObject enemy;
    [SerializeField] Rigidbody2D rigidbody;
    


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemyTarget = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        enemy.gameObject.GetComponent<Rigidbody2D>();

        // rigidbody.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, target.position) < 3.5)
        {
            rigidbody.MovePosition(Vector3.MoveTowards(transform.position, target.position, movingSpeed * Time.deltaTime));
        }
        /*
        if (Vector2.Distance(transform.position, enemyTarget.position) < 1)
        {
            rigidbody.MovePosition(new Vector2(transform.position.x + 1, transform.position.y + 1));
        }

        */
    }
    
}
