using System;
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

    private PlayerInstance currentInstance;

    private void Start()
    {
        LoadOrStart();
    }

    private void LoadOrStart()
    {
        PlayerInstance saveInstance = SaveManager.LoadPlayerInstance();

        if (saveInstance != null)
        {
            currentInstance = saveInstance;
        }
        else
        {
            currentInstance = new PlayerInstance(null);
        }
        
        
    }

    public void StartItem(PlayerInstance playerInstance)
    {
        if (playerInstance != null)
        {
            item = currentInstance.currentitemData;
        }
        else
        {
            item = null;
        }
    }
    
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
