using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    public int CurrentHealth;
    public int maxHealth;
    public int attack;

    public HealthBar healthBar;


    void Start()
    {
        CurrentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    

    public void TakeDamage(int amount)
    {
        CurrentHealth -= amount;
    }

    public void Damage(int amount)
    {
        this.CurrentHealth -= amount;
    }
    void Update()
    {
        healthBar.SetHealth(CurrentHealth);
    }
}
