using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 7f;
    private float verticalInput;

    private Rigidbody2D rb;

    [SerializeField] private bool isPlayer1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isPlayer1)
        {
            verticalInput = Input.GetAxisRaw("Vertical1");
        }
        else
        {
            verticalInput = Input.GetAxisRaw("Vertical2");
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x, verticalInput * speed);
    }
}
