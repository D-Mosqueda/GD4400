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
            if(Collision.GetComponent<Enemy>() != null)
            {
                Collision.GetComponent<Enemy>().DealDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}
