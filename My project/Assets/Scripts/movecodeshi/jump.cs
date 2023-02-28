using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class jump : MonoBehaviour
{
    public Vector3 jump1;
    public float jumpForce = 4f;

    public bool isGrounded;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump1 = new Vector3(0.0f, 3.5f, 0.0f);
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