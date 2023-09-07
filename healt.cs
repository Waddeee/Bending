using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public int maxHealth = 100; // Maximum health points
    private int currentHealth;  // Current health points

    private void Start()
    {
        currentHealth = maxHealth; // Initialize current health to max health
    }

    // Function to take damage
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        // Check if the character's health has dropped to or below zero
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Function to handle the character's death
    private void Die()
    {
        // Perform death-related actions here (e.g., play an animation, deactivate the character, trigger game over, etc.)
        Debug.Log("Character has died.");

        // Optionally, you can destroy the GameObject or deactivate it to prevent further interactions.
        // gameObject.SetActive(false);
        // Destroy(gameObject);
        
    }
}

    
  
