using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Factor de ralentización cuando el juego termina
    public float slow = 10f;

    // Método para manejar el final del juego
    public void EndGame()
    {
        // Inicia la corrutina para reiniciar el nivel
        StartCoroutine(RestartLevel());
    }

    // Corrutina para reiniciar el nivel con un efecto de ralentización
    IEnumerator RestartLevel()
    {
        // Reduce la escala de tiempo para simular un ralentización
        Time.timeScale = 1f / slow;

        // Ajusta el tiempo fijo en consecuencia
        Time.fixedDeltaTime /= slow;

        // Espera un tiempo antes de continuar
        yield return new WaitForSeconds(2f / slow);

        // Restaura la escala de tiempo a su valor normal
        Time.timeScale = 1f;

        // Restaura el tiempo fijo a su valor normal
        Time.fixedDeltaTime *= slow;

        // Carga la escena "Pause"
        SceneManager.LoadScene("Pause");
    }
}
