using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> Enemies = new List<GameObject> ();
    public float spawnRate;


    void Start()
    {
        StartCoroutine(SpawnTestEnemy());    
    }

    IEnumerator SpawnTestEnemy()
    {
        Instantiate(Enemies[Random.Range(0,3)], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(spawnRate);
        StartCoroutine(SpawnTestEnemy());
    }



}
