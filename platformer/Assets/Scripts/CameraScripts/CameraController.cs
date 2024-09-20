using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 50;
    float angle = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            angle -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.E))
        {
            angle += speed * Time.deltaTime;
        }
        Camera.main.transform.Rotate(Vector3.forward, angle);
    }
}
