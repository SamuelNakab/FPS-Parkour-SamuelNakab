using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    public TextMeshPro txtMoney;


    public void UpdateMoneyText(string money)
    {
        txtMoney.text = "$" + money;
    }
}
