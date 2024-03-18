using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    // Variable estática para almacenar la distancia total recorrida por los jugadores
    public static int distance;

    // Variable para controlar el tiempo
    public float t = 0;

    // Referencia al objeto de texto en el que se mostrará la distancia
    public Text text;

    void Start()
    {
        // Inicializa la distancia a 0 al inicio del juego
        distance = 0;
    }

    void Update()
    {
        // Aumenta el tiempo con el tiempo de cada cuadro
        t = t + Time.deltaTime;

        // Comprueba si ha pasado un segundo
        if (t > 1)
        {
            // Reinicia el tiempo
            t = 0;

            // Incrementa la distancia
            distance++;
        }

        // Actualiza el texto para mostrar la distancia
        text.text = distance.ToString();
    }
}
