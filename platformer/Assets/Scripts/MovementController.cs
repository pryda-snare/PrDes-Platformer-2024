using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementController : MonoBehaviour
{
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
        
        // movement along the y axis 
        if (Input.GetKey(KeyCode.W))
        {
            pos.y += distance;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= distance;
        }
        
        transform.position = pos;
    }
}
