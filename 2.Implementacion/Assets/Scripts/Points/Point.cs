using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    // Se llama cuando este objeto colisiona con otro objeto en 2D
    void OnCollisionEnter2D(Collision2D col)
    {
        // Verifica si el objeto con el que colisionó tiene la etiqueta "Player"
        if (col.gameObject.tag == "Player")
        {
            // Destruye este objeto (el objeto que tiene este script)
            Destroy(gameObject);

            // Reproduce el sonido asociado a obtener puntos
            FindObjectOfType<AudioManager>().Play("GotPoint");

            // Incrementa la puntuación del jugador (Score)
            Score.score++;
        }
    }
}
