using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Cards/Card")]
public class Card : ScriptableObject
{
    public string cardTitle;
    public string cardDescription;
    public Sprite cardImage; // Optional: an image for the card
}