using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyProjectile : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter2D(Collider2D Collision)
    {
        //print(Collision.tag);
        if (Collision.tag != "Enemy")
        {
            /*if (Collision.GetComponent<EnemyReceiveDamage>() != null)
            {
                Collision.GetComponent<EnemyReceiveDamage>().DealDamage(damage);
            }*/
            if(Collision.tag == "Player")
            {
                PlayerStats.playerStats.DealDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}
