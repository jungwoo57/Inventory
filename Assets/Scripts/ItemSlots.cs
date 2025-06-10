using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemSlots : MonoBehaviour
{
    public Inventory inventory;
    public int index;
    public bool equiped;
	public ItemData item;
	public Button button;
	public Image icon;
	
	public void Set()
	{
		icon.gameObject.SetActive(true);
		if (item != null)
		{
			icon.sprite = item.icon;
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
