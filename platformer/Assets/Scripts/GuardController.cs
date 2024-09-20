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

    public GameObject[] waypoints;
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

        // TODO W1.4
        // Make an "if" statement that checks if the "absolute" distance 
        // between the position and the destination is smaller than the "distance" variable 
        // that is assigned above.
        // In that "if" statement call the function "NextWayPoint"
        // Now you've finished the WAYPOINTS 1 excersise 
        ////////////////////////////////////////////////////////////////////////////////////////////////////
            //if (Mathf.Abs(pos.x - dest.x) < distance)
            //{
            //    NextWaypoint();
            //}
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        
        // TODO W2.2
        // Comment Out what you did in "TODO: W1.4".
        // Call the Method/function "TargetClosest" from the previous step.
        // Now you've finished the WAYPOINTS 2 excersise 
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        TargetClosest();
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        transform.position = pos;
    }

    // TODO W1.3
    // 1. Make a function that is private, takes and returns no variables and is called NextWaypoint.
    // 2. In this function iterate the "index" variable by one.
    // 3. using the modulus inbuilt function make sure the "index" variable stays 
    //    within the size of the "waypoints" variables size.
    // 4. Assign the "target" variable the gameobject at "index" index in the "waypoints" variable list 
    // Next step "TODO: W1.4"
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    private void NextWaypoint()
    {
        index++;
        index = index % waypoints.Length;
        target = waypoints[index];
    }
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    

    // TODO W2.1
    // 1. Make a function that is private, takes and returns no variables and is called TargetClosest.
    // 2. Make an empty gameobject variable called "closest". 
    // 3. Make a double variable called "shortset" and assign it the C# double maxvalue.
    // 4. Make a for each loop taht iterates through the "waypoints" variable and assigns them to a variable called "waypoint"
    //      4-1. in the loop get the distance between the waypoint and this objects position and assign it to a
    //           double variable called "dist"
    //      4-2. in the loop make a if statement that checks if the "dist" variable is smaller than the "shortest" variable.
    //              4-2-1. in the if statement assign the "shortest" variable the "dist" variable.
    //              4-2-2. assign the "closest" variable the "waypoint" variable.
    // 5. assign the "target" variable the "closest" variable **OUTSIDE THE FOR EACH LOOP**
    // Next step "TODO: W2.2"
    ////////////////////////////////////////////////////////////////////////////////////////////////////
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
    ////////////////////////////////////////////////////////////////////////////////////////////////////
}
