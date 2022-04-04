using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float speed;

    private Transform target;

    [SerializeField] GameObject enemy;
    [SerializeField] Rigidbody2D rigidbody;
    


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();



    }

    // Update is called once per frame
    void Update()
    {
        int randomX = Random.Range(1, 7);
        int randomY = Random.Range(1, 7);
        transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, -1), target.position, speed * Time.deltaTime);
        rigidbody.position = new Vector3(transform.position.x, transform.position.y, -1);
        rigidbody.MovePosition(new Vector2(transform.position.x, transform.position.y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("This should trigger.");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemy.transform.position = new Vector3(enemy.transform.position.x + 3, transform.position.y + 3, -1);
        }
    }
}
