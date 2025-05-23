using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccionDelColisiones : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("contacto");
        Destroy(gameObject);
    }
}
