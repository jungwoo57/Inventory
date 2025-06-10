using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
   [Header("ItemData")] 
   public string name;
   public int atk;
   public int hp;
}
