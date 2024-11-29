using TMPro;
using UnityEngine;

public class addjumpforceWithoutIf : MonoBehaviour
{
    public int HowMuchToAd = -2;
    public TextMeshProUGUI textToshow;

    private void Start()
    {
        textToshow.text = "" + HowMuchToAd;
    }


    void OnTriggerEnter2D(Collider2D col)
    {
            HowMuchToAd++;
            textToshow.text = "" + HowMuchToAd;
    }
}