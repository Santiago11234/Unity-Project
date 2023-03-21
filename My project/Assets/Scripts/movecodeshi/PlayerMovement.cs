using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{



    public bool isMoving = false;

    [Header("Movement")]
    public float moveSpeed;
    public Vector3 startPos;
    public float groundDrag;


    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    bool readyToJump;

    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;


    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    [Header("Portal")]
    public int n;
    public Vector3[] arr = new Vector3[2]; 
  

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        arr[0] = new Vector3(0,0,0);
        arr[1] = new Vector3(10,10,10);
        n =0;

        transform.position = startPos;
        
    }

    /*function moveCheck()
    {
        var p1 = transform.position;
        yield WaitForSeconds(0.5);
        var p2 = transform.position;

        IsMoved = (p1 != p2);
    }
    */

        private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        if (transform.hasChanged)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        /*if(Input.GetKey(jumpKey) && readyToJump && grounded)
        {
            readyToJump = false;
            Jump();
            Invoke(nameof(ResetJump), jumpCooldown);
        }
        */
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        if (grounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);

        }
        else if (!grounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
        }
    }

    private void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);

        MyInput();

        //moveCheck();

        SpeedControl();

        if (grounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = 0;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
    }
    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if(flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
        
    }

    private void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }

    private void ResetJump()
    {
        readyToJump = true;
    }


     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Portal"))
        {
            Debug.Log("u just got hit L bozo");
            SceneManager.LoadScene("Dungeon");
            
        }

        if (other.CompareTag("shark"))
        {
            
            Debug.Log("You Died");
            transform.position = startPos;
        }
        if (other.CompareTag("ocean"))
        {
            
            Debug.Log("You Died");
            transform.position = startPos;
        }
    }

}
