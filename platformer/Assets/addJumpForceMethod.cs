using UnityEngine;
using TMPro;

public class addJumpForceMethod : MonoBehaviour
{
    private bool check = false;
    private bool check2 = false;
    public TextMeshProUGUI textToshow;

    public GameObject otherobject;
    public addToJumpForce otherscript;

    //private addjumpforceWithoutIf otherscript;

    private void Start()
    {
        otherscript = otherobject.GetComponent<addToJumpForce>();
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && check == false && check2 == true)
        {
            otherscript.number++;
            textToshow.text = "" + otherscript.number;
            check = true;
        }
        else
        {
            Debug.Log("already inside trigger");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            check = false;
        }
    }

    private void OnDisable()
    {
        check2 = false;
    }

    private void OnEnable()
    {
        check2 = true;
    }
}

