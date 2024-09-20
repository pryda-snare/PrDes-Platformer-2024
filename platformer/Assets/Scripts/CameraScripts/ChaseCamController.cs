using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCamController : MonoBehaviour
{
    public GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            this.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = target.transform.position;
        position.z = -1;
        transform.position = position;
    }
}
