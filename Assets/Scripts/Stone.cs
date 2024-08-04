using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Stone : MonoBehaviour, ICollectible
{
   public static event HandleStoneCollected OnStoneCollected;
   public delegate void HandleStoneCollected(ItemData itemData);
   public ItemData stoneData;

public void Collect()
{
    //Debug.Log("You Have Collected Stone");
    OnStoneCollected?.Invoke(stoneData);
}
}

