using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dashing : MonoBehaviour
{
    /*
    public Transform orientation;
    public Transform playerCam;
    private Rigidbody rb;
    private PlayerMovementDashing pm;


    public float dashForce;
    public float dashUpwardForce;
    public float dashDuration;


    public float dashCD;
    private float dashCdTimer;

    

    public KeyCode dashKey*/

    public float dashSpeed;
    Rigidbody rb;
    bool isDashing;

    public GameObject dashEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isDashing = true;
        }
    }
    private void FixedUpdate()
    {
        if (isDashing)
        {
            Dashy();
        }
    }


    private void Dashy()
    {
        rb.AddForce(-transform.forward * dashSpeed, ForceMode.Impulse);
        isDashing = false;

        GameObject effect = Instantiate(dashEffect, Camera.main.transform.position, dashEffect.transform.rotation);
        effect.transform.parent = Camera.main.transform;
        effect.transform.LookAt(transform);
    }
}
