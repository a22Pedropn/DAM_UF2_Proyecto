using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLeft : MonoBehaviour
{
    // Rigidbody del jugador
    public Rigidbody2D rbb;

    // Fuerza de salto del jugador
    public float jumpforce = 10f;

    // Tecla para saltar (asignada desde el Editor de Unity)
    public KeyCode left;

    // Enumeración para el estado del jugador
    public enum State
    {
        normal,   // Estado normal, no está saltando
        jumping   // Estado de salto
    }

    // Estado actual del jugador
    public State s;

    void Update()
    {
        // Verifica si la tecla asignada está siendo presionada y el jugador no está saltando
        if (Input.GetKey(left) && s == State.normal)
        {
            // Aplica fuerza hacia la izquierda para simular un salto
            rbb.velocity = Vector2.left * jumpforce;

            // Cambia el estado a "saltando"
            s = State.jumping;
        }
    }

    // Se llama cuando el jugador colisiona con otros objetos
    void OnCollisionEnter2D(Collision2D col)
    {
        // Si colisiona con el suelo, vuelve al estado normal
        if (col.gameObject.tag == "Ground")
        {
            s = State.normal;
        }

        // Si colisiona con un bloque o un peligro, termina el juego
        if (col.gameObject.tag == "Block" || col.gameObject.tag == "Danger")
        {
            // Reproduce el sonido de "Game Over"
            FindObjectOfType<AudioManager>().Play("Gameover");

            // Llama al método EndGame en el GameManager
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
