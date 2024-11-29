using TMPro;
using UnityEngine;

public class enableJump : MonoBehaviour
{
    public  jumpController targetScript;
    private bool check = false;
    public TextMeshProUGUI textToshow;

    //for disabling the other
    public GameObject disGameObject;
    private DisableJump disjump;

    private void Start()
    {
        disjump = disGameObject.GetComponent<DisableJump>();

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && check==false)
        {
            targetScript.enabled = true;
            textToshow.color = Color.green;
            disjump.turnoffColorMethod();
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
        textToshow.color = Color.white;
    }

}
