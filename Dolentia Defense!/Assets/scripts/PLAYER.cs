using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    public float velocidade;
    public new Rigidbody2D RIG;

    void Start()
    {
        
    }
    void Update()
    {
        float hori = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        //variaveis criadas para controlar as direcoes da nave

        float velocidadeHORI = (hori * this.velocidade);
        float velocidadeVERT = (vert * this.velocidade);
        //mult as velocidades

        this.RIG.velocity = new Vector2(velocidadeHORI, velocidadeVERT);
        //vector2 eh uma variavel que guarda dois valores
    }

    

}
