using SpaceShooter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour, IHealth {

    private int _currentHealth;

    public int CurrentHealth
    {
        get
        {
            return _currentHealth;
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
            _currentHealth -= amount;
        }
        else
        {
            _currentHealth = MinimumHealth;
        }
    }

    public void IncreaseHealth(int amount)
    {
        if ((CurrentHealth + amount) <= MaximumHealth)
        {
            _currentHealth += amount;
        }
        else
        {
            _currentHealth = MaximumHealth;
        }
    }

    private void Awake()
    {
        _currentHealth = StartingHealth;
    } 
}
