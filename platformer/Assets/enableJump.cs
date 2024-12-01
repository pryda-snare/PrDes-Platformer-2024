using TMPro;
using UnityEngine;

public class enableJump : MonoBehaviour
{
    public jumpController targetScript;
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
            targetScript.enabled = true; //enable jump script
            textToshow.color = Color.green;
            disjump.turnoffColorMethod();
    }

    public void turnoffColorMethod()
    {
        textToshow.color = Color.white;
    }

}
