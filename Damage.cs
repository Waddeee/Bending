using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damageAmount = 10; // Amount of damage this attack deals

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object collided with has a HealthController script
        HealthController healthController = other.GetComponent<HealthController>();

        // If it has a HealthController, inflict damage
        if (healthController != null)
        {
            healthController.TakeDamage(damageAmount);
        }
    }
}

