using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Inventory : MonoBehaviour
{
    public ItemSlots[] slots;
    public Transform slotPanel;

    public ItemSlots curItem;
    public int curItemIndex;
    public ItemSlots selectedItem;
    public int selectItemIndex;
    
    private void Start()
    {
        slots = new ItemSlots[slotPanel.childCount];

        for (int i = 0; i < slots.Length; i++)
        {
            slots[i] = slotPanel.GetChild(i).GetComponent<ItemSlots>();
            slots[i].index = i;
            slots[i].inventory = this;
        }
        UpdateUI();
        gameObject.SetActive(false);
    }

    void AddItem()
    {
        ItemData data = PlayerManager.Instance.Player.itemData;
        PlayerManager.Instance.Player.itemData = null;
        
    }

    ItemSlots GetEmtpySlot()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item == null)
            {
                return slots[i];
            }
        }
        return null;
        
    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i] != null)
            {
                slots[i].Set();
            }
            else
            {
                slots[i].Clear();
            }
        }
    }

    public void SelectItem(int index)
    {
        if(slots[index].item == null) return;

        if (slots[selectItemIndex].equiped)
        {
            UnEquip(selectItemIndex);
        }

        slots[index].equiped = true;
        selectedItem = slots[index];
        selectItemIndex = index;
        curItemIndex = index;
        PlayerManager.Instance.Player.status.item = slots[index].item;
        UpdateUI();
        
    }

    public void UnEquip(int index)
    {
        slots[index].equiped = false;
        /*if (selectItemIndex == index)
        {
            SelectItem(selectItemIndex);
        }*/
    }
}
