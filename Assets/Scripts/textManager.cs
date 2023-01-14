using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textManager : MonoBehaviour
{
    public static textManager instance;

    public Text moneyText;

    public int money;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Data data = SaveSystem.LoadData();
        
        money = data.balance;

        moneyText.text = "Balance: " + money.ToString() + " $";
    }

    public void AddMoney()
    {
        money = money + 10;
        moneyText.text = "Balance: " + money.ToString() + " $";

        SaveSystem.SaveData(this);
    }

    public int findMoney()
    {
        return money;
    }
}
