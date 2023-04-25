using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab; // referência ao GameObject "Bullet"
    public Transform bulletSpawn; // local onde o tiro será instanciado
    public KeyCode shootButton = KeyCode.Space; // botão do teclado que dispara o tiro
    public float fireRate = 0.5f; // tempo entre os tiros
    private float nextFire = 0.0f; // próximo tiro

    private void Update()
    {
        if (Input.GetKey(shootButton) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate; // atualiza o tempo do próximo tiro
            GameObject tiro = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity); // instancia o tiro
            tiro.GetComponent<SpriteRenderer>().sortingOrder = 10;
        }
    }

}