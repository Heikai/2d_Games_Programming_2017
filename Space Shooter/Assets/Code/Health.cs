using SpaceShooter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour, IHealth {

    public int CurrentHealth
    {
        get
        {
            return CurrentHealth;
        }

        set
        {
            CurrentHealth = value;
        }
    }

    [SerializeField]
    public int StartingHealth = 100;

    [SerializeField]
    public int MinimumHealth = 0;

    [SerializeField]
    public int MaximumHealth = 200;

    public void DecreaseHealth(int amount)
    {
        if ((CurrentHealth - amount) >= MinimumHealth)
        {
            CurrentHealth -= amount;
        }
    }

    public void IncreaseHealth(int amount)
    {
        if ((CurrentHealth + amount) <= MaximumHealth)
        {
            CurrentHealth += amount;
        }
    }

    private void Awake()
    {
        CurrentHealth = StartingHealth;
    } 
}
