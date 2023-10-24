using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed, jumpForce;
    public SpriteRenderer sr;

    private Vector2 moveInput;

    public LayerMask Ground;
    public Transform groundPoint;
    private bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        moveInput.Normalize();

        rb.velocity = new Vector3(moveInput.x * moveSpeed, rb.velocity.y ,moveInput.y * moveSpeed);

        if (moveInput.x < 0 )
        {
            sr.flipX = true;
        }else if (moveInput.y < 0 )
        {
            sr.flipX = false;
        }

        RaycastHit hit;
        if (Physics.Raycast(groundPoint.position, Vector3.down, out hit, .3f, Ground))
        {
            isGrounded= true;
        }else
        {
            isGrounded= false;
        }

        if(Input.GetButtonDown("Jump") && isGrounded) 
        {
            rb.velocity += new Vector3(0f, jumpForce, 0f);
        }



    }

   
}
