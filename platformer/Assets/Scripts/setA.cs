using TMPro;
using UnityEngine;


public class SetA : MonoBehaviour
{
    public enum SetType { A, B, C }
    public SetType type;
    private int number;

    public TextMeshProUGUI textToshow;
    public LoopScript loopScript;


    private void Start()
    {
        textToshow.text = "" + number;

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        switch (type)
        {
            case SetType.A:
                HandleSetA();
                break;
            case SetType.B:
                HandleSetB();
                break;
            case SetType.C:
                HandleSetC();
                break;
        }
        textToshow.text = "" + number;
    }

    void HandleSetA()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            loopScript.a -= 1;
            number -= 1;
        }
        else
        {
            loopScript.a += 1;
            number += 1;
        }
    }

    void HandleSetB()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            loopScript.b -= 1;
            number -= 1;
        }
        else
        {
            loopScript.b += 1;
            number += 1;
        }
    }

    void HandleSetC()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            loopScript.c -= 1;
            number -= 1;
        }
        else
        {
            loopScript.c += 1;
            number += 1;
        }
    }


}