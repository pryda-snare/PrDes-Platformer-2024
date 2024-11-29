using System;
using UnityEngine;
using TMPro;

public class colorcontrol : MonoBehaviour
{
    public TextMeshProUGUI txt;
    private bool check = false;



    void Start()
    {

    }




    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && check == false)
        {
            //look for butt tag
            GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("butt");
            foreach (GameObject obj in taggedObjects)
            {
                var colorController = obj.GetComponent<colorcontrol>();

                if (colorController != null)
                {
                    colorController.turnoffColorMethod();
                }
            }
            txt.color = Color.green;
            check = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            check = false;
        }
    }


    public void turnoffColorMethod()
    {
        txt.color = Color.white;
    }



}

