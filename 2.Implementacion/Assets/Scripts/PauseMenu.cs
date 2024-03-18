using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Variable estática que indica si el juego está pausado
    public static bool GameIsPaused = false;

    // Referencia al objeto de la interfaz de usuario (UI) del menú de pausa
    public GameObject pauseMenuUI;

    // Se llama en cada cuadro de actualización del juego
    void Update()
    {
        // Verifica si la tecla Escape se presiona
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Si el juego está pausado, resumir; de lo contrario, pausar
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    // Método para resumir el juego
    public void Resume()
    {
        // Desactiva el menú de pausa
        pauseMenuUI.SetActive(false);

        // Restaura el tiempo normal en el juego
        Time.timeScale = 1f;

        // Indica que el juego no está pausado
        GameIsPaused = false;
    }

    // Método para pausar el juego
    void Pause()
    {
        // Activa el menú de pausa
        pauseMenuUI.SetActive(true);

        // Pausa el tiempo en el juego
        Time.timeScale = 0f;

        // Indica que el juego está pausado
        GameIsPaused = true;
    }
}
