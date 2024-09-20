using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeScrollController : MonoBehaviour
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
        var pos = Camera.main.WorldToViewportPoint(target.transform.position);
        if (pos.x > 1 || pos.x < 0 || pos.y > 1 || pos.y < 0)
        {
            var moveTo = target.transform.position;
            moveTo.z = -1;
            transform.position = moveTo;
        }
    }
}
