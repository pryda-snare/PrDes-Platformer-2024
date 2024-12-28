using UnityEngine;
using System.Collections.Generic;

public class applyTag : MonoBehaviour
{
    public string[] Tags = { "Player", "Enemy", "butt", "fruit" };

    public string TagToGet = "Player";
    public int GetIndex;

    public string TagToSet = "Player";
    public int SetIndex;

    public string GetTag()
    {
        TagToGet = Tags[GetIndex];
        GetIndex++;
        if (GetIndex >= Tags.Length) { GetIndex = 0; }
        Debug.Log(TagToGet);
        return TagToGet;
    }

    public string SetTag()
    {
        TagToSet = Tags[SetIndex];
        SetIndex++;
        if (SetIndex >= Tags.Length) { SetIndex = 0; }
        Debug.Log(TagToSet);
        return TagToSet;
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("penis  "+TagToGet+ "  " + GetIndex);
            GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(TagToGet);
            Debug.Log(TagToGet);
            foreach (GameObject obj in taggedObjects)
            {
                obj.tag = TagToSet;
            }
        }
    }

}
