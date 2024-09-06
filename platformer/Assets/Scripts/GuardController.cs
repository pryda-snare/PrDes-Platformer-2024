using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardController : MonoBehaviour
{
    public GameObject[] waypoints;
    public GameObject target;
    public int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        target = waypoints[index];
    }

    // Update is called once per frame
    void Update()
    {
        var target_pos = target.transform.position;
        var pos = transform.position;
        var dist = 2 * Time.deltaTime;

        if (target_pos.x > pos.x)
        {
            pos.x = pos.x + dist;
        }
        else
        {
            pos.x = pos.x - dist;
        }

        if (dist > Mathf.Abs(pos.x - target_pos.x))
        {
            NextTarget();
        }
        //ClosestTarget();

        transform.position = pos;
    }

    private void ClosestTarget()
    {
        GameObject best_target = null;
        float best_dist = float.MaxValue;
        foreach(var waypoint in waypoints)
        {
            var dist = Vector3.Distance(transform.position, waypoint.transform.position);
            if (dist < best_dist)
            {
                best_dist = dist;
                best_target = waypoint;
            }
        }
        target = best_target;
    }

    private void NextTarget()
    {
        index++;
        index = index % waypoints.Length;
        target = waypoints[index];
    }
}
