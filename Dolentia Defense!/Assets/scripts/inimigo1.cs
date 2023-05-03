using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo1 : MonoBehaviour
{
      public float speed = 10f; // velocidade de movimento do inimigo
      public int health = 5; // quantidade de vida do inimigo
    
      private Rigidbody2D rb;
      private bool isHit = false;

    
 
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }
    
    
    void Update()
    {
        if (!isHit)
               {
                   // Movimentação horizontal do inimigo pra esquerda
                   Vector2 movement = new Vector2(-speed, 0);
                   rb.MovePosition(rb.position + movement * Time.deltaTime);
               }
       
     }
      void OnTriggerEnter2D(Collider2D other)
         {
               // Se o inimigo for atingido pela bala do jogador, perde 1 de vida
                     if (other.tag == "Tirorapido")
                     {
                         health--;
                         if (health <= 0)
                         {
                             Destroy(gameObject);
                         }
                         isHit = true;
                         StartCoroutine(HitDelay());
                     }
         }
     
        IEnumerator HitDelay()
        {
             yield return new WaitForSeconds(0.2f); // aguarda 0.2 segundos
             isHit = false;
        }    
}

