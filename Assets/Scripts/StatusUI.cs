using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class StatusUI : MonoBehaviour
{
    public TextMeshProUGUI name;
    public TextMeshProUGUI level;

    private void Start()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        name.text = "NAME : " + PlayerManager.Instance.Player.status.name;
        level.text = "LV : " + PlayerManager.Instance.Player.status.level.ToString();
    }
}
