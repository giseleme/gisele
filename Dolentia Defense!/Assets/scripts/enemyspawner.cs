using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public GameObject enemy1Prefab;
    public GameObject enemy2Prefab;
    public int numberOfEnemy1ToSpawn = 5;
    public float timeBetweenEnemySpawns = 2f;
    
    private int inimigo1 = 0; //vezes que o inimigo foi instanciado
    
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }
    
    IEnumerator SpawnEnemies()
    {
        while (inimigo1 < numberOfEnemy1ToSpawn)
        {
            Instantiate(enemy1Prefab, transform.position, Quaternion.identity);
            inimigo1++;
            yield return new WaitForSeconds(timeBetweenEnemySpawns);
        }
        
        Instantiate(enemy2Prefab, transform.position, Quaternion.identity);
    }
}
