using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TestAbility : MonoBehaviour
{
    public GameObject projectile;
    public float minDamage;
    public float maxDamage;
    public float projectileForce;


    private void Update()
    {
        if (!PauseMenu.isPaused)
        {

            if (Input.GetMouseButtonDown(0))
            {
                GameObject spell = Instantiate(projectile, transform.position, Quaternion.identity);
                Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                //MyPos needs to be declared as Vector2 first then normalized. Normalized takes as Vector3 so Declaring vector2 tosses Z value.
                Vector2 myPos = transform.position;
                Vector2 direction = (mousePos - myPos).normalized;

                spell.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
                spell.GetComponent<testProjectile>().damage = UnityEngine.Random.Range(minDamage, maxDamage);
            }
        }
    }










}
