using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health;
    public int damage;
    public float speed;
    public float timeBetweenAttacks;

    protected Transform player;

    public virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("PlayerX").transform;
    }

    void Update()
    {

    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

}
