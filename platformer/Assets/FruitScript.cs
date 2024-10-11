using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor.U2D;
using UnityEngine;

public class FruitScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Dictionary<string, Sprite> sprites = new Dictionary<string,Sprite>();
    public string fruitTag = "Apple_0"; 
    void Start()
    {

        Sprite[] allSpritesFromFolder = Resources.LoadAll<Sprite>("");
        foreach (Sprite sprite in allSpritesFromFolder){
            sprites.Add(sprite.name, sprite);
        }
        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        renderer.sprite = sprites[fruitTag];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
