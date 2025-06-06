using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaSript : MonoBehaviour
{
    public MoneyManager moneyManager;
    public float cost = 5;

    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (moneyManager.UpdateMoeny(-cost))
            {
                Destroy(gameObject);
            }
        }
    }
}
