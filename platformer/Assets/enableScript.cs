using UnityEngine;
using System.Collections.Generic; //need to use a list

public class enableScript : MonoBehaviour
{
    public List<MonoBehaviour> scriptsToEnable;
    public List<MonoBehaviour> scriptsToDisable;
    public bool check = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && check == false)
        {
            foreach (var script in scriptsToEnable)
            {
                script.enabled = true;
            }
            foreach (var script in scriptsToDisable)
            {
                script.enabled = false;
            }
        }
        else
        {
            Debug.Log("already inside trigger or not the player");
        }
    }
}
