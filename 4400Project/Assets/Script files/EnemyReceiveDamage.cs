using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyReceiveDamage : MonoBehaviour
{
    public float health;
    public float maxHealth;


    //Sets Health to MaxHealth at start
    private void Start()
    {
        health = maxHealth;
    }


    //Changes Health based on damage done and check if death occurs
    public void DealDamage(float damage)
    {
        health -= damage;
        CheckDeath();
    }


    //Deals with Healing beyond Max health. Simply sets Health to MaxHealth, Removing any issues with "overhealing"
    private void Overheal()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    //Checks if Dead
    private void CheckDeath()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }


}
