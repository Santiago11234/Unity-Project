using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    [Header("Knockback")]
    public float knockbackForce = 10f;
    public float knockbackDuration = 0.5f;
    public bool leftRight = false;

    private bool isKnockingBack = false;
    private Vector3 knockbackDirection;

    [Header("Rotation")]
    public float maxAngle = 60;
    public float rotationSpeed = 1;

    void Update()
    {
        float angle = Mathf.Sin(Time.time * rotationSpeed) * maxAngle;
        transform.rotation = Quaternion.Euler(180f ,0f , angle);

        if(leftRight) 
            transform.rotation = Quaternion.Euler(angle, 180f , 0f);
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
    
            // playerRb.AddForce(knockbackDirection * knockbackForce , ForceMode.Impulse);

            playerRb.velocity = new Vector3(knockbackDirection.x, .5f, knockbackDirection.z) * knockbackForce;

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
