using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This will be a vague list of actions to complete the exercise waypoints in LearnIt
// steps will follow a order using the syntax Wx.y 
// where W = waypoints, x = which excersise (e.g. excersise 1) and y = step nr.

// Exercise: WAYPOINTS 1
// W1.0 - find the "TODO: W1.1" comment in this script for the next step

// Exercise: WAYPOINTS 2
// W2.0 - find the "TODO: W2.1" comment in this script for the next step

public class GuardController : EnemyClass
{
    public GuardController(int hp, int damage, int speed, EnemyType type, Image sprite)
    {
        this.hp = hp;
        this.damage = damage;
        this.speed = speed;
        this.type = type;
        this.sprite = sprite;
    }

    GameObject[] waypoints;
    public int index = 0;
    
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        target = waypoints[index];
    }

    // Update is called once per frame
    void Update()
    {
        var dest = target.transform.position;
        var pos = transform.position;
        var distance = speed * Time.deltaTime;

        if (pos.x > dest.x)
        {
            pos.x -= distance;
        }
        else
        {
            pos.x += distance;
        }

        TargetClosest();

        transform.position = pos;
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
              double dist = Vector3.Distance(transform.position, waypoint.transform.position);
              if (dist < shortest)
              {
                   shortest = dist;
                   closest = waypoint;
              }
          }
          target = closest;
     }
}
