using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public HealthBar healthBar;


    void Start()
    {
        currentHealth = maxHealth;
        healthBar = GetComponent<HealthBar>();
        healthBar.SetMaxHealth(maxHealth);
    }

    private void takeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void Update()
    {
        healthBar.SetHealth(currentHealth);
    }
}
