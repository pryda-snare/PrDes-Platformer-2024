using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        Vector3 dest = target.transform.position;
        Vector3 pos = transform.position;
        float distance = 2 * Time.deltaTime;

        if (pos.x > dest.x)
        {
            pos.x -= distance;
        }
        else
        {
            pos.x += distance;
        }
        
        if (pos.y > dest.y)
        {
            pos.y -= distance;
        }
        else
        {
            pos.y += distance;
        }

        transform.position = pos;
    }
}
