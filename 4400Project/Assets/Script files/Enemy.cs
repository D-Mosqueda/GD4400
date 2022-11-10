using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float health;
    public float maxHealth;


    public GameObject healthBar;
    public Slider healthBarSlider;
    public GameObject lootDrop;


    //Sets Health to MaxHealth at start
    private void Start()
    {
        health = maxHealth;
    }


    //Changes Health based on damage done and check if death occurs
    public void DealDamage(float damage)
    {
        healthBar.SetActive(true);
        

        health -= damage;
        CheckDeath();
        healthBarSlider.value = HealthPercentage();
    }

    public void HealCharacter(float heal)
    {
        health += heal;
        Overheal();
        healthBarSlider.value = HealthPercentage();
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
            Instantiate(lootDrop, transform.position, Quaternion.identity);
        }
    }

    private float HealthPercentage()
    {
        return (health / maxHealth);
    }


}
