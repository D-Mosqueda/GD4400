using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> Enemies = new List<GameObject> ();
    public float spawnRate;
    int rand = 0;
    public 


    void Start()
    {
        StartCoroutine(SpawnTestEnemy());    
    }

    private void Update()
    {
        if(GameObject.Find("Boss") == null)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator SpawnTestEnemy()
    {
        rand = Random.Range(0, 9);
        Debug.Log(rand);
        if (rand >= 5)
        {
            Instantiate(Enemies[Random.Range(0, 3)], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnRate);
            StartCoroutine(SpawnTestEnemy());
        }
        else
        {
            yield return new WaitForSeconds(spawnRate);
            StartCoroutine(SpawnTestEnemy());
        }
    }



}
