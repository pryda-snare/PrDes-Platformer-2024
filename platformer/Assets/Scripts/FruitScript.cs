using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor.U2D;
using UnityEngine;

public class FruitScript : MonoBehaviour, ICollectible
{
    // Start is called before the first frame update
    public Dictionary<string, Sprite> sprites = new Dictionary<string,Sprite>();
    public string fruitTag = "Apple_0"; 

    //Reference to the Player
    public MovementController movementController;

    void Start()
    {
        // Get all the "Sprite" resources from the "Resource" folder in the Sprite[] array
        Sprite[] allSpritesFromFolder = Resources.LoadAll<Sprite>("");
        // Iterate over all the sprites and add them into the dictionary so we can refer to them by their name
        foreach (Sprite sprite in allSpritesFromFolder){
            sprites.Add(sprite.name, sprite);
        }
        // Get the renderer component
        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        // Apply the sprite from the dictionary to the renderer sprite
        renderer.sprite = sprites[fruitTag];

        // *******************************************************
        // Alternatively, a more elegant solution without the dictionary is:
        // *******************************************************
        // Sprite[] allSpritesFromFolder = Resources.LoadAll<Sprite>("");
        // foreach (Sprite sprite in allSpritesFromFolder){
        //    if (sprite.name == fruitTag){
        //        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        //        renderer.sprite = sprite;
        //    }
        //    sprites.Add(sprite.name, sprite);
        //}
        //

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Collect()
    {
        //Setup player jump boost state and timer
        movementController.isBoosted = true;
        movementController.boostCounter = 0;
    }
}
