using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private GameObject playerObj = null;
    Vector3 lastGrounded;

    public CharacterController controller;
    // movement speed
    public float speed = 15f;

    // for gravity
    Vector3 velocity;
    public float gravity = -21f;

    // Check if player is on ground
    public Transform groundCheck;
    public float groundDistance = 0.25f;
    public LayerMask groundMask;

    bool isGrounded;

    // set height for jump
    public float jumpHeight = 5f;

    // Start is called before the first frame update
    void Start()
    {
        if (playerObj == null)
            playerObj = FindObjectOfType<PlayerMovement>().gameObject;
    }


    // Update is called once per frame
    void Update()
    {
        // looking
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        // moving
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        // gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        // on ground
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (isGrounded)
        {
            lastGrounded = new Vector3(playerObj.transform.position.x, playerObj.transform.position.y, playerObj.transform.position.z);
        }
        // jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        // run
        // while on the ground and holding down shift you will run
        if (Input.GetKey(KeyCode.LeftShift) && isGrounded)
        {
            speed = 30;
        }
        // while on the ground and not holding shift you will walk
        if (!Input.GetKey(KeyCode.LeftShift) && isGrounded)
        {
            speed = 15;
        }

        if(playerObj.transform.position.y < 9.5f)
        {
            transform.position = lastGrounded;
            isGrounded = false;
        }
    }
    
}
