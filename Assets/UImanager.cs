using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI helathText;


    public void UpdateMoneyText(string money)
    {
        txtMoney.text = "$" + money;
    }
    public void UpdateHealthText(string health)
    {
        helathText.text = health;
    }
}
