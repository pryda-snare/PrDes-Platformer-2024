using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Rigidbody2D playerBody;
    public float moveSpeed = 5f; // Movement speed

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get horizontal input (-1 for A, +1 for D, or 0 for no input)
        float horizontalInput = 0;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            horizontalInput = 1;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalInput = -1;
        }

        // Apply horizontal velocity
        playerBody.linearVelocity = new Vector2(horizontalInput * moveSpeed, playerBody.linearVelocity.y);
    }
}
