using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject target;

    private void FindTarget()
    {
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject obj in taggedObjects)
        {
            target = obj;
        }
    }


    private void Start()
    {
        FindTarget();
    }

    void Update()
    {
        if(target != null)
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

            transform.position = pos;
        }
        else { FindTarget(); }

    }
}
