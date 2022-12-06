using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats playerStats;
    public GameObject player;
    public TextMeshProUGUI healthText;
    public Slider HealthSlider;
    public float health;
    public float maxHealth;

    public int coins;
    public TextMeshProUGUI coinsValue;

    public int healthPots;
    public TextMeshProUGUI healthPotsValue;

    //private Inventory inventory;

   // [SerializeField] private ui_Inventory uiInventory;


    private void Awake()
    {
        /*inventory = new Inventory();
        uiInventory.SetInvetory(inventory);
        */
        if (playerStats != null)
        {
            Destroy(playerStats);
        }
        else
        {
            playerStats = this;
        }
        DontDestroyOnLoad(this);

        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            HealCharacter();
        }
    }

    //Sets Health to MaxHealth at start
    private void Start()
    {

        health = maxHealth;
        SetHealthUI();
        InvokeRepeating("addHealthPot", 1.0f, 40.0f);

    }

    private void SetHealthUI()
    {
        HealthSlider.value = 1;
        healthText.text = Mathf.Ceil(health).ToString() + " / " + Mathf.Ceil(maxHealth).ToString();
    }

    //Changes Health based on damage done and check if death occurs
    public void DealDamage(float damage)
    {
        health -= damage;
        CheckDeath();
        SetHealthUI();
    }

    public void HealCharacter()
    {
        if (!PauseMenu.isPaused)
        {
            if (healthPots > 0)
            {
                int heal = 50;
                health += heal;
                Overheal();
                SetHealthUI();
                healthPots = healthPots - 1;
                healthPotsValue.text = "x" + healthPots.ToString();
                if (healthPots <= 0)
                {
                    healthPots = 0;
                    healthPotsValue.text = "x" + healthPots.ToString();
                }
            }
        }
        
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
            health = 0;
            Destroy(player);
        }
    }

    float CalculateHealthPercentage()
    {
        return health / maxHealth;
    }

    public void addCurrency(CurrencyPickup currency)
    {
        if ( currency.currentObject == CurrencyPickup.pickupObject.COIN)
        {
            coins += currency.pickupvalue;
            coinsValue.text = "x" + coins.ToString();
        }
        
    }
    public void addHealthPot()
    {
        healthPots = healthPots + 1;
        healthPotsValue.text = "x" + healthPots.ToString();

    }



}
