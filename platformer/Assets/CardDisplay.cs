using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card; // Assign the ScriptableObject card here

    public Text titleText;
    public Text descriptionText;
    public Image cardImage;

    private void Start()
    {
        DisplayCard();
    }

    public void DisplayCard()
    {
        titleText.text = card.cardTitle;
        descriptionText.text = card.cardDescription;

        if (card.cardImage != null)
        {
            cardImage.sprite = card.cardImage;
            cardImage.enabled = true;
        }
        else
        {
            cardImage.enabled = false; // Hide the image if none is assigned
        }
    }
}