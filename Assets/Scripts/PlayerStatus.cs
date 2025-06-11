using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [field: SerializeField] public string name { get; private set; }
    [field: SerializeField] public int atk { get; private set; }
    [field: SerializeField] public int hp { get; private set; }
    [field: SerializeField] public int level { get; private set; }
    [field: SerializeField] public int itemIndex { get; set; }
    [field: SerializeField] public ItemData item;

    [field: SerializeField] public int lastAtk;
    [field: SerializeField] public int lastHp;

    
    public void CalculateStatus()
    {
        if (item != null)
        {
            lastAtk = atk + item.atk;
            lastHp = hp + item.hp;
        }
        else
        {
            lastAtk = atk;
            lastHp = hp;
        }
    }
}
