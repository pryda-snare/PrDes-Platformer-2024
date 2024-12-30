using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinalDoor : MoveUP
{
    public TextMeshProUGUI textToShow;
    public TextMeshProUGUI text2;
    public int timesToWin;

 void Update()
    {
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("fruit");
        text2.text = "currently " + taggedObjects.Length + " Fruits in level";
    }

    private void Start()
    {
        timesToWin = FruitDic.Count;
        textToShow.text = $"Have " + DicValue() + " Fruits in level to open the green gate";
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player" || col.gameObject.tag =="Player")
        {
            if (timesCompleted < timesToWin)
            {
                OnLevelComplete(); // in MoveUP script
            }
            else
            {
                OnFinalLevelComplete(); // in MoveUP script (because inheritence)
            }
        }
    }
}