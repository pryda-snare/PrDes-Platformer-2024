using UnityEngine;
using static UnityEditor.PlayerSettings;
using System.Collections.Generic;
using System.Diagnostics;


public class LoopScript : MonoBehaviour
{
    public GameObject platform;
    public Vector2 initPosition;
    public int a = 3;
    public int b = 3;
    public int c = 3;

    private List<GameObject> clonesList = new List<GameObject>();
 

    void Start()
    {
        initPosition = platform.transform.position;
    }


void OnTriggerEnter2D(Collider2D col)
    {
        initPosition = platform.transform.position;
        foreach (GameObject obj in clonesList)
        {
            Destroy(obj);
        }
        clonesList.Clear();

        for (int i = 0; i < a; i++)
        {
        initPosition.x += b;
        initPosition.y += c;
        GameObject clone = Instantiate(platform, initPosition, Quaternion.identity);
        clonesList.Add(clone);
        }
    }
}
