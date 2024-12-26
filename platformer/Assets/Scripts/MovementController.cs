using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementController : MonoBehaviour
{
    public Rigidbody2D playerBody;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        float distance = 5 * Time.deltaTime;
        
        // movement along the x axis
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += distance;
        }
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= distance;
        }
        
        transform.position = pos;
    }
}
