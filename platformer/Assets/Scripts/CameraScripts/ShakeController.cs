using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ShakeController : MonoBehaviour
{
    public float min = 0;
    public float max = 0.5f;

    private Vector3 original;

    private void OnEnable()
    {
        original = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var x = original.x + Random.Range(min, max);
        var y = original.y + Random.Range(min, max);
        
        transform.position = new Vector3(x, y, original.z);
    }

    private void OnDisable()
    {
        transform.position = original;
    }
}
