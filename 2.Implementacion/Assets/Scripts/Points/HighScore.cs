using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    // Referencia al objeto de texto en el que se mostrará el puntaje más alto
    public Text text;

    // Variables para almacenar la distancia y la puntuación del jugador
    private int s;
    private int d;

    // Variables para almacenar la puntuación y la distancia del segundo jugador (¿quizás?)
    private int s1;
    private int d1;

    // Variable estática para almacenar el puntaje más alto
    public static int highscore;

    void Start()
    {
        // Obtiene la puntuación y la distancia del primer jugador
        d = Distance.distance;
        s = Score.score;

        // Calcula el puntaje más alto sumando la puntuación y la distancia del primer jugador
        highscore = s + d;

        // Muestra el puntaje más alto en el objeto de texto
        text.text = highscore.ToString();
    }
}
