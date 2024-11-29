using UnityEngine;
using TMPro;

public class addJumpForceMethod : MonoBehaviour
{
    private bool check = false;
    public int HowMuchToAdd = -2;
    public TextMeshProUGUI textToshow;

    private void Start()
    {
        textToshow.text = ""+HowMuchToAdd;
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && check == false)
        {
            HowMuchToAdd++;
            textToshow.text = "" + HowMuchToAdd;
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

}

