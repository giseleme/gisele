using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro1 : MonoBehaviour
{

    private void Fire()
    {
        // Instancia a bala a partir do prefab
    GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

    // Configura a velocidade da bala
    bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        Fire()
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
