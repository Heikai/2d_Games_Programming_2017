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
    private int StartingHealth = 100;

    [SerializeField]
    private int MinimumHealth = 0;

    [SerializeField]
    private int MaximumHealth = 200;

    public void DecreaseHealth(int amount)
    {
        if ((CurrentHealth - amount) >= MinimumHealth)
        {
            CurrentHealth -= amount;
        }
        else
        {
            CurrentHealth = MinimumHealth;
        }
    }

    public void IncreaseHealth(int amount)
    {
        if ((CurrentHealth + amount) <= MaximumHealth)
        {
            CurrentHealth += amount;
        }
        else
        {
            CurrentHealth = MaximumHealth;
        }
    }

    private void Awake()
    {
        CurrentHealth = StartingHealth;
    } 
}
