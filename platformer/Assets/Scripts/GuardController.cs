using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GuardController : ChaseObject
{
    public GameObject[] waypoints;
    public int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        target = waypoints[index];
    }

    // Update is called once per frame
    void Update()
    {
        TargetClosest();
        ChaseTarget();
 
    }
    
    private void NextWaypoint()
    {
        index++;
        index = index % waypoints.Length;
        target = waypoints[index];
    }
    
    private void TargetClosest()
    {
        GameObject closest = null;
        double shortest = double.MaxValue;
        foreach (var waypoint in waypoints) 
        {
            if (waypoint != null)
            {
                double dist = Vector3.Distance(transform.position, waypoint.transform.position);
                if (dist < shortest)
                {
                    shortest = dist;
                    closest = waypoint;
                }
            }
        }
        target = closest;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("killed");
            Destroy(other.gameObject);
        }
    }
}
