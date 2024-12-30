using TMPro;
using UnityEngine;


public class addjumpforceWithoutIf : addJumpForceMethod
{
    //public TextMeshProUGUI textToshow;
    private int val = 1;

    //private addToJumpForce otherscript;
    //public GameObject otherobject;

    private void Start()
    {
        otherscript = otherobject.GetComponent<addToJumpForce>();
        textToshow.text = "" + otherscript.number;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        otherscript.number += val;
        textToshow.text = "" + otherscript.number;
    }


    private void OnDisable()
    {
        val = 0;
    }

    private void OnEnable()
    {
        val = 1;
    }

}

