using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rrrr : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;
    private bool isTouchingWall;
    private float wallJumpCooldown = 0.1f;
    private float lastWallJumpTime;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(transform.position, 0.2f, groundLayer);
        isTouchingWall = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, 0.2f);

        Move();
        Jump();
        WallJumpCooldown();
    }

    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        // Wall jump
        if (Input.GetButtonDown("Jump") && isTouchingWall && Time.time - lastWallJumpTime > wallJumpCooldown)
        {
            rb.velocity = new Vector2(-transform.localScale.x * moveSpeed, jumpForce);
            lastWallJumpTime = Time.time;
        }
    }

    private void WallJumpCooldown()
    {
        if (isGrounded)
        {
            lastWallJumpTime = Time.time;
        }
    }
}