using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Método para cambiar a una escena específica
    public void ChangeToScene(string scene)
    {
        // Inicia la corrutina Restart con la escena específica
        StartCoroutine(Restart(scene));
    }

    // Corrutina para reiniciar la escena con un fundido
    IEnumerator Restart(string scene)
    {
        // Obtiene el tiempo de fundido desde el objeto con el script FadeScene
        float fadeTime = GameObject.Find("Fade").GetComponent<FadeScene>().BeginFade(1);

        // Espera el tiempo de fundido antes de continuar
        yield return new WaitForSeconds(fadeTime);

        // Carga la nueva escena
        SceneManager.LoadScene(scene);
    }

    // Método para salir de la aplicación
    public void Exit()
    {
        // Cierra la aplicación
        Application.Quit();
    }
}
