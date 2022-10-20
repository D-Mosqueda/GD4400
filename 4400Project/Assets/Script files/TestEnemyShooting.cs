using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class TestEnemyShooting : MonoBehaviour
{
    public GameObject projectile;
    public float minDamage;
    public float maxDamage;
    public float projectileForce;
    public Transform player;
    public float Cooldown;


    void Start()
    {
        StartCoroutine(ShootPlayer());
    }

    IEnumerator ShootPlayer()
    {
        yield return new WaitForSeconds(Cooldown);
        if(player != null)
        {
            GameObject Shoot = Instantiate(projectile, transform.position, Quaternion.identity);

            Vector2 myPos = transform.position;
            Vector2 targetPos = player.position;

            Vector2 direction = (targetPos - myPos).normalized;
            Shoot.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
            Shoot.GetComponent<TestEnemyProjectile>().damage = Random.Range(minDamage, maxDamage);
            StartCoroutine(ShootPlayer());
        }
        
    }
}
