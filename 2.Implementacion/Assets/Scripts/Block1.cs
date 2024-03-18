using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block1 : MonoBehaviour
{
    // Se llama en cada cuadro de actualización del juego
    void Update()
    {
        // Verifica si la posición en el eje Y del objeto es menor que -6
        if (transform.position.y < -6f)
        {
            // Destruye este objeto (el bloque) si su posición es menor que -6
            Destroy(gameObject);
        }
    }
}
