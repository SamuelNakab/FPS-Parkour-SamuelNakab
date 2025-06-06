using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UImanager uiManager;

    public bool UpdateMoeny(float amount)
    {
        if(money + amount < 0)
        {
            Debug.Log("Dinero Insuficiente");
            return false;
        }
        else
        {
            money += amount;
            uiManager.UpdateMoneyText(money.ToString());
            return true;
        }
    }
}
