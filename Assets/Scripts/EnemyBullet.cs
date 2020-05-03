using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private Player playerScript;
    private Vector2 targetPosition;

    public float speed;
    public int damage;

    private void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("PlayerX").GetComponent<Player>();
        targetPosition = playerScript.transform.position;
    }


    private void Update()
    {
        //if ((Vector2)transform.position == targetPosition)
        if (Vector2.Distance(transform.position, targetPosition)<=0.1f)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerX"))
        {
            playerScript.TakeDamage(damage);
            Destroy(gameObject);
        }

    }
}
