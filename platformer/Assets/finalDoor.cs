using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinalDoor : MoveUP
{
    public TextMeshProUGUI textToShow;
    public TextMeshProUGUI text2;
    public int timesToWin = 10;

 void Update()
    {
        text2.text = "currently " + Fruits + " Fruits in level";
    }

    private void Start()
    {
        textToShow.text = $"Have " + DicValue() + " Fruits in level to open the green gate";
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (timesCompleted < timesToWin)
            {
                OnLevelComplete();
            }
            else
            {
                OnFinalLevelComplete();
            }
        }
    }
}