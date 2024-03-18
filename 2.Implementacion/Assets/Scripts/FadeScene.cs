using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScene : MonoBehaviour
{
    // Textura de fundido que se muestra durante el cambio de escena
    public Texture2D fadeOutTexture;

    // Velocidad de fundido
    public float fadeSpeed = 0.7f;

    // Profundidad de dibujo en la interfaz gráfica de usuario (GUI)
    private int drawdepth = -1000;

    // Valor de opacidad (alpha)
    private float alpha = 1.0f;

    // Dirección del fundido (-1 para desvanecerse, 1 para aparecer)
    private int dir = -1;

    // Se llama cada vez que se renderiza la interfaz gráfica de usuario (GUI)
    void OnGUI()
    {
        // Actualiza el valor de opacidad según la dirección y la velocidad de fundido
        alpha += dir * fadeSpeed * Time.deltaTime;

        // Asegura que el valor de opacidad esté en el rango de 0 a 1
        alpha = Mathf.Clamp01(alpha);

        // Configura el color de la interfaz gráfica de usuario con la nueva opacidad
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);

        // Configura la profundidad de dibujo en la interfaz gráfica de usuario
        GUI.depth = drawdepth;

        // Dibuja la textura de fundido en toda la pantalla
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);
    }

    // Inicia el fundido con la dirección dada y devuelve la velocidad de fundido
    public float BeginFade(int direction)
    {
        // Establece la dirección del fundido
        dir = direction;

        // Devuelve la velocidad de fundido
        return fadeSpeed;
    }

    // Se llama cuando se carga una nueva escena
    void OnLevelWasLoaded()
    {
        // Inicia un fundido saliente cuando se carga una nueva escena
        BeginFade(-1);
    }
}
