using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data
{
    public int balance;

    public Data(textManager score)
    {
        balance = score.money;
    }
}
