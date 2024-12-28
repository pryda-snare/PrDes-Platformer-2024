using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MoveUP : MonoBehaviour
{
    public static int timesCompleted = 0; // Use static to persist across scenes
    public int Fruits = 0;

    protected Dictionary<int, int> FruitDic = new()
    {
    { 0, 0 },
    { 1, 1 },
    { 2, 3 },
    { 3, 5 },
    { 4, 6 },
    { 5, 9 },
    { 6, 12 },
    { 7, 16 },
    { 8, 20 },
    { 9, 25 },
};


    public void MovUp()
    {
        gameObject.transform.position += new Vector3(0, 0.005f, 0);
    }

    private void Update()
    {
        // Find all objects with tag fruit
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("fruit");
        Fruits = taggedObjects.Length;

        // Check if the number of tagged objects match Dicvalue to open gate
        if (Fruits == DicValue())
        {
            MovUp();
        }
    }

    protected int DicValue()
    {
        if (FruitDic.ContainsKey(timesCompleted))
        {
            return FruitDic[timesCompleted];
        }
        else
        {
            return 999;
        }
    }

    // level logic
    protected void OnLevelComplete()
    {
        timesCompleted++;
        SceneManager.LoadScene("lesson4");
    }

    protected void OnFinalLevelComplete()
    {
        timesCompleted=0;
        SceneManager.LoadScene("win");
    }

}