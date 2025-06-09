using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int hp;
    public UImanager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType <UImanager>();
    }

    public bool UpdateHp(int damage)
    {
        if (hp + damage < 0)
        {
            Debug.Log("Te quedaste sin puntos de vida");
            SceneManager.LoadScene("FPS parkour");
            Debug.Log("Hola");
            return false;
        }
        else
        {
            hp += damage;
            uiManager.UpdateHealthText(hp.ToString());
            Debug.Log("HOLA");
            return true;
        }
    }
}
