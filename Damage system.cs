using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    public float weaponRange = 10f; // Range of the weapon.
    public int damageAmount = 10; // Amount of damage to apply to the target.

    void Update()
    {
        // Check for user input to fire the weapon (e.g., mouse click).
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse position in the world coordinates.
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Perform a raycast from the weapon's position towards the mouse position.
            RaycastHit2D hit = Physics2D.Raycast(transform.position, mousePosition - (Vector2)transform.position, weaponRange);

            // Check if the raycast hit something.
            if (hit.collider != null)
            {
                // Check if the hit object has a Damageable component.
                Damageable damageable = hit.collider.GetComponent<Damageable>();
                if (damageable != null)
                {
                    // Apply damage to the target.
                    damageable.TakeDamage(damageAmount);
                }
            }
        }
    }
}


