using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollectible
{
    //All Collectibles need to have a Collect feature upon collection
    void Collect();
}