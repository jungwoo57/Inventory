using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerInstance
{
    public ItemData currentitemData;

    public PlayerInstance(ItemData itemData)
    {
        this.currentitemData = itemData;
    }

}

public class SaveManager
{
    private const string SaveKey = "PlayerInstance";

    public static void SavePlayerInstance(PlayerInstance instance)
    {
        string json = JsonUtility.ToJson(instance);
        PlayerPrefs.SetString(SaveKey, json);
        PlayerPrefs.Save();
    }
    public static PlayerInstance LoadPlayerInstance()
    {
        if (PlayerPrefs.HasKey(SaveKey))
        {
            string json = PlayerPrefs.GetString(SaveKey);
            return JsonUtility.FromJson<PlayerInstance>(json);
        }

        return null;
    }
}

