using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Inventory : MonoBehaviour
{
    public Item[] hasItem;
    public Button[] slot;
    public ItemSlots[] slots;
    public Transform slotPanel;

    private void Start()
    {
        gameObject.SetActive(false);
        slots = new ItemSlots[slotPanel.childCount];

        for (int i = 0; i < slots.Length; i++)
        {
            slots[i] = slotPanel.GetChild(i).GetComponent<ItemSlots>();
            slots[i].index = i;
            slots[i].Inventory = this;
        }
    }

    void AddItem()
    {
        ItemData data = PlayerManager.Instance.Player.itemData;
        //ItemSlots emptySlot = GetEmptySlot();
        //emptySlot
        PlayerManager.Instance.Player.itemData = null;
        
    }

    ItemSlots GetEmtpySlot()
    {
        return null;
    }
}
