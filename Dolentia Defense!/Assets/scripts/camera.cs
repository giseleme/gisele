using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target; // referência para o objeto que a câmera deve seguir
    public float smoothSpeed = 0.125f; // velocidade de suavização do movimento da câmera
    public Vector3 offset; // posição da câmera em relação ao objeto

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        smoothedPosition.y = 0;
        transform.position = smoothedPosition;

        Debug.Log("Camera position: " + transform.position);
    }
}
