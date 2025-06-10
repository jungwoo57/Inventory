using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject statusPanel;
    public GameObject inventoryPanel;
    
    
    public void OpenStatusPanel()
    {
        statusPanel.SetActive(true);
    }

    public void CloseStatusPanel()
    {
        statusPanel.SetActive(false);
    }

    public void OpenInventory()
    {
        inventoryPanel.SetActive(true);
    }

    public void CloseInventory()
    {   
        inventoryPanel.SetActive(false);
    }
    
}
