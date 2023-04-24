using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tirorapido : MonoBehaviour
{
    public float speed = 10f; // velocidade do tiro

    private void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed; // define a direção e velocidade do tiro
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject); // destrói o tiro quando colide com outro objeto
    }
}
  

