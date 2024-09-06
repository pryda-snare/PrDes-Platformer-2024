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

        if (pos.x - 1 > dest.x)
        {
            pos.x -= distance;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (pos.x + 1 < dest.x)
        {
            pos.x += distance;
            GetComponent<SpriteRenderer>().flipX = false;
        }

        transform.position = pos;
    }
}
