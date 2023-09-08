using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour, Damageable
{
    public int maxHealth = 100;
    private int currentHealth;

    // Initialize current health to the max health when the object is created.
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        // Reduce the current health by the damage amount.
        currentHealth -= damageAmount;

        // Check if the object has been destroyed.
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Perform any death-related actions here.
        // For example, destroy the object or play an animation.
        Destroy(gameObject);
    }
}
