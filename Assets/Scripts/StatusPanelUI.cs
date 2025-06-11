using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatusPanelUI : MonoBehaviour
{
    public int atk;
    public int hp;
    public TextMeshProUGUI showAtk;
    public TextMeshProUGUI showHp;

    public void UpdateUI()
    {
        PlayerManager.Instance.Player.status.CalculateStatus();
        atk = PlayerManager.Instance.Player.status.lastAtk;
        hp = PlayerManager.Instance.Player.status.lastHp;
        
        showAtk.text = "Attack : " + atk.ToString();
        showHp.text = "Hp : " + hp.ToString();
    }

}
