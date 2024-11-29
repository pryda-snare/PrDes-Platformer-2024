using TMPro;
using UnityEngine;

public class DisableJump : MonoBehaviour
{
    public jumpController targetScript;
    private bool check = false;
    public TextMeshProUGUI textToshow;

    //for disabling the other
    public GameObject enGameObject;
    private enableJump enjump;

    private void Start()
    {
        enjump = enGameObject.GetComponent<enableJump>();

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && check == false)
        {
            targetScript.enabled = false;
            textToshow.color = Color.green;
            enjump.turnoffColorMethod();
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
