using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyPickup : MonoBehaviour
{
    public enum pickupObject {COIN};
    public pickupObject currentObject;



    public int pickupvalue;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {

            PlayerStats.playerStats.addCurrency(this);
            Debug.Log(PlayerStats.playerStats.coins);
            
            Destroy(gameObject);
        }
    }









}
