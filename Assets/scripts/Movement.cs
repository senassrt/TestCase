using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 12f;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;
    private float moveInput;

    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Ground check using OverlapCircle
        moveInput = Input.GetAxisRaw("Horizontal");
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        // Jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        animator.SetFloat("speed",Mathf.Abs(moveInput));
        
        // Rotate player on Y-axis based on direction
        if (moveInput < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0); // Facing left
        }
        else if (moveInput > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);   // Facing right
        }

    }

    void FixedUpdate()
    {
        // Move player

        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }

    public void PlayMeeleAnimation()
    {
        animator.SetTrigger("attack");
    }
    
}
