using TMPro;
using UnityEngine;

public class DisableJump : MonoBehaviour
{
    public jumpController targetScript;
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
            SetColorMethod(Color.green);
            enjump.SetColorMethod(Color.white);
            Debug.Log(MyName());
    }

    public void SetColorMethod(Color C)
    {
        textToshow.color = C;
    }

    public string MyName()
    {
        return gameObject.name + "activated";
    }

}
