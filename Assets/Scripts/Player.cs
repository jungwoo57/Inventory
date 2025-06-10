using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    public PlayerStatus status;
    public ItemData itemData;
    private void Awake()
    {
        PlayerManager.Instance.Player = this;
        status = GetComponent<PlayerStatus>();
    }
}
