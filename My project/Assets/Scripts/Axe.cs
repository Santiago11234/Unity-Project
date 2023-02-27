using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    [Header("Knockback")]
    public float knockbackForce = 500f;
    public float knockbackDuration = 0.5f;

    private bool isKnockingBack = false;
    private Vector3 knockbackDirection;

    [Header("Rotation")]
    public float maxAngle = 85;
    public float rotationSpeed = 1;

    void Update()
    {
        float angle = Mathf.Sin(Time.time * rotationSpeed) * maxAngle;
        transform.rotation = Quaternion.Euler(angle, 0f, 0f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isKnockingBack)
        {
            // Calculate knockback direction away from the axe
            knockbackDirection = other.transform.position - transform.position;
            knockbackDirection.Normalize();

            // Apply knockback force to the player
            Rigidbody playerRb = other.GetComponent<Rigidbody>();
            PlayerMovement playerMovement = other.GetComponent<PlayerMovement>();
            if (playerRb != null && playerMovement != null)
            {
                
                
                playerRb.AddForce(knockbackDirection * knockbackForce, ForceMode.Impulse);

                // Start knockback coroutine
                StartCoroutine(KnockbackCoroutine(playerMovement));
            }
        }
    }

    IEnumerator KnockbackCoroutine(PlayerMovement playerMovement)
    {
        isKnockingBack = true;

        // Wait for knockback duration
        yield return new WaitForSeconds(knockbackDuration);

        isKnockingBack = false;
    }   
}
