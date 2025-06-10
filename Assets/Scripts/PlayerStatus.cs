using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [field: SerializeField] public string name { get; private set; }
    [field: SerializeField] public int atk { get; private set; }
    [field: SerializeField] public int hp { get; private set; }
    [field: SerializeField] public int level { get; private set; }


}
