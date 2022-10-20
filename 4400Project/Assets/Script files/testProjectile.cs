using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testProjectile : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.name != "Player")
        {
            if(Collision.GetComponent<EnemyReceiveDamage>() != null)
            {
                Collision.GetComponent<EnemyReceiveDamage>().DealDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}
