using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : ChaseObject
{

    // Update is called once per frame
    void Update()
    {
        ChaseTarget();
    }
}
