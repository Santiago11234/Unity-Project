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
        transform.rotation = Quaternion.Euler(180f ,0f , angle);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isKnockingBack)
        {
            Debug.Log("u just got hit L bozo");

            knockbackDirection = other.transform.position - transform.position;
            knockbackDirection.Normalize();

            Rigidbody playerRb = other.GetComponent<Rigidbody>();
            PlayerMovement playerMovement = other.GetComponent<PlayerMovement>();
    
            playerRb.AddForce(knockbackDirection * knockbackForce /30, ForceMode.Impulse);

            StartCoroutine(KnockbackCoroutine(playerMovement));
            
        }
    }

    IEnumerator KnockbackCoroutine(PlayerMovement playerMovement)
    {
        isKnockingBack = true;
        yield return new WaitForSeconds(knockbackDuration);
        isKnockingBack = false;
    }   
}
