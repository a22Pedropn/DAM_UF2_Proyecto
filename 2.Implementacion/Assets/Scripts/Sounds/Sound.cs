using UnityEngine.Audio;
using UnityEngine;

// Serializable indica que esta clase se puede ver y editar en el Editor de Unity
[System.Serializable]
public class Sound
{
    // Nombre del sonido
    public string name;

    // Clip de audio que representa el sonido
    public AudioClip clip;

    // Rango de tono (pitch) permitido para el sonido
    [Range(.1f, 3f)]
    public float pitch;

    // Rango de volumen permitido para el sonido
    [Range(0f, 1f)]
    public float volume;

    // Indica si el sonido debe reproducirse en bucle
    public bool loop;

    // AudioSource asociado a este sonido
    [HideInInspector]
    public AudioSource source;
}
