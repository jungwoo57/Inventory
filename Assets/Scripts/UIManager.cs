using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public StatusPanelUI statusPanel;
    public GameObject inventoryPanel;
    
    
    public void OpenStatusPanel()
    {
        statusPanel.gameObject.SetActive(true);
        statusPanel.UpdateUI();
    }

    public void CloseStatusPanel()
    {
        statusPanel.gameObject.SetActive(false);
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
