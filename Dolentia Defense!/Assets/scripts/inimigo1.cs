using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo1 : MonoBehaviour
{
    public int health = 1;
    public float speed = 6f;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (health <= 0)
        {
            Die();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colidiu");
        
        if (collision.CompareTag("Tirorapido"))
        {
            health--;
            Destroy(collision.gameObject);
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}

