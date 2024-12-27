using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.UIElements;

public class MovementController : MonoBehaviour
{
    public Rigidbody2D playerBody;

    public float moveSpeed = 5f; // Movement speed
    public float horizontalInput = 0;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalInput = 0;
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
