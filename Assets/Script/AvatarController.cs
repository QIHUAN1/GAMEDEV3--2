using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarController : MonoBehaviour
{

    [Header("Movement")]
    private float horizontal;
    public float speed = 8f;
    private bool isFacingRight = true;
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        
    }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        Flip(); 
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;

        }
    }
}