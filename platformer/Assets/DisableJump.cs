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
            targetScript.enabled = false; //disable jump script
            textToshow.color = Color.green;
            enjump.turnoffColorMethod();
    }


    public void turnoffColorMethod()
    {
        textToshow.color = Color.white;
    }
}
