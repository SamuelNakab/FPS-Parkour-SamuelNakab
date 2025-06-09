using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagerScript : MonoBehaviour
{
    public HealthManager healthManager;
    public int damage = 35;

    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);
        if (collision.gameObject.CompareTag("Player"))
        {
            if (healthManager.UpdateHp(-damage))
            {
                Destroy(gameObject);
            }
        }
    }
}
