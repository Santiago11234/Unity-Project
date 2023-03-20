using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class DungeonJump : MonoBehaviour
{
    public Vector3 jump1;
    public float jumpForce = 4f;

    public bool isGrounded;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump1 = new Vector3(0.0f, 1.75f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump1 * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

    }
}