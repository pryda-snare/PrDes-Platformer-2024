using UnityEngine;
using static UnityEditor.PlayerSettings;
using System.Collections.Generic;

public class LoopScript : MonoBehaviour
{
    public GameObject platform;
    public Vector2 initPosition;
    public int a = 3;
    public int b = 3;
    public int c = 3;

    private List<GameObject> clonesList = new List<GameObject>();
 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initPosition = platform.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
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
            for (int j = 0; j < b; j++)
            {
                initPosition.x += 1;
            }
            for (int k = 0; k < c; k++)
                {
                    initPosition.y += 1;
                }
        GameObject clone = Instantiate(platform, initPosition, Quaternion.identity);
        clonesList.Add(clone);
        }
    }

}

