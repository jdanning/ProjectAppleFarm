﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStats : MonoBehaviour
{

    [SerializeField] private float maxHealth = 500;

    //This is a property. Use MaxHealth when accessing 
    public float MaxHealth
    {
        get
        {
            return maxHealth;
        }
        set
        {
            maxHealth = value;
            healthUIUpdate();
        }
    }

    [SerializeField] private float currHealth;
    //This is a property. Use CurrHealth when accessing 
    public float CurrHealth
    {
        get
        {
            return currHealth;
        }
        set
        {
            currHealth = value;
            healthUIUpdate();
        }
    }

    public float damage = 10;
    public float defense = 10;
    public float speed;
    public Slider slider;
    public TextMeshProUGUI maxHealthUI;
    public TextMeshProUGUI currHealthUI;

    // Start is called before the first frame update
    void Start()
    {
        currHealth = maxHealth;
    }

    // updates health UI 
    void Update()
    {
       
    }

    void healthUIUpdate()
    {
        slider.value = (currHealth / maxHealth) * 100;
        currHealthUI.SetText((Mathf.Round(currHealth)).ToString());
        maxHealthUI.SetText("/ " + maxHealth.ToString());
    }

    public void takeDamage(float amount)
    {
        CurrHealth -= amount;
        if(CurrHealth <= 0)
        {
            //trigger loss
            Destroy(gameObject);
        }
    }


}
