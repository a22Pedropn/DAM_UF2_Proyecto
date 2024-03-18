using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Variable estática para almacenar la puntuación del jugador
    public static int score;

    // Referencia al objeto de texto en el que se mostrará la puntuación
    public Text text;

    void Start()
    {
        // Inicializa la puntuación a 0 al inicio del juego
        score = 0;
    }

    void Update()
    {
        // Actualiza el texto para mostrar la puntuación actual
        text.text = score.ToString();
    }
}
