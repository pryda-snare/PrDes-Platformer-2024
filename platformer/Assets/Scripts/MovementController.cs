using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementController : MonoBehaviour
{
    public float jumpForce = 5.0f;
    public bool grounded = false;
    
    
    public Rigidbody2D playerBody;

    void Start()
    {
       playerBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 pos = transform.position;
        float distance = 5 * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += distance;
        }
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= distance;
        }
        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.Space) && grounded)  
        {
            grounded = !grounded;
            playerBody.velocity = new Vector2(playerBody.velocity.x, jumpForce);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        grounded = true;
    }
}
