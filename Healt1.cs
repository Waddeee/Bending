using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Change this to your desired input for attacking (e.g., shooting).
        {
            ShootRaycast();
        }
    }

    rivate void ShootRaycast()
{
    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Vector2 origin = transform.position;
    
    // Calculate the direction from the object to the mouse position.
    Vector2 direction = (mousePosition - transform.position).normalized;

    // Cast a ray from the object in the calculated direction.
    RaycastHit2D hit = Physics2D.Raycast(origin, direction, Mathf.Infinity);

    if (hit.collider != null)
    {
        // Check if the hit object has a HealthSystem component.
        HealthSystem targetHealth = hit.collider.GetComponent<HealthSystem>();

        if (targetHealth != null)
        {
            // Apply damage to the target's health.
            targetHealth.TakeDamage(10); // You can adjust the damage value as needed.
        }
    }
}

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        // Check if the object is destroyed.
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        print died

        // Perform death-related actions (e.g., destroy the GameObject).
        Destroy(gameObject);
    }
    
}

