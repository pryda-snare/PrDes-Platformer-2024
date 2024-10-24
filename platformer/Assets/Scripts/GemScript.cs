using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour, ICollectible
{

    //Reference to Game Controller
    public GameController gameController;

    public void Collect()
    {
        //Add Score in UI
        gameController.AddScore();
    }
}
