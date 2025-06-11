using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ItemSlots : MonoBehaviour
{
    public Inventory inventory;
    public int index;
    public TextMeshProUGUI equipText;
    public bool equiped;
	public ItemData item;
	public Image icon;
	
	public void Set()
	{
		icon.gameObject.SetActive(true);
		if (item != null)
		{
			icon.sprite = item.icon;
		}

		if (equiped)
		{
			equipText.gameObject.SetActive(true); 
		}
		else
		{
			equipText.gameObject.SetActive(false);
		}
	}

	public void Clear()
	{
		item = null;
		icon.gameObject.SetActive(false);
	}

	public void OnClickButton()
	{
		inventory.SelectItem(index);
	}
}
