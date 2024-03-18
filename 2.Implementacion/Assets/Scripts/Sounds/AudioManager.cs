using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    // Arreglo de sonidos que se pueden reproducir en el juego
    public Sound[] sounds;

    // Instancia estática del AudioManager para asegurar que solo haya una instancia activa en el juego
    public static AudioManager instance;

    // Se llama al inicio del juego
    void Start()
    {
        // Reproduce el sonido "Theme" al iniciar el juego
        Play("Theme");
    }

    // Se llama antes de que cualquier script de juego se ejecute
    void Awake()
    {
        // Verifica si ya hay una instancia del AudioManager
        if (instance == null)
        {
            // Si no hay ninguna instancia, establece esta como la instancia activa
            instance = this;
        }
        else
        {
            // Si ya hay una instancia, destruye esta para evitar duplicados
            Destroy(gameObject);
            return;
        }

        // Hace que este objeto no se destruya al cargar una nueva escena
        DontDestroyOnLoad(gameObject);

        // Configura cada sonido en el arreglo de sonidos
        foreach (Sound s in sounds)
        {
            // Añade un componente AudioSource al objeto y configura sus propiedades
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    // Método para reproducir un sonido por su nombre
    public void Play(string name)
    {
        // Busca el sonido con el nombre dado en el arreglo de sonidos
        Sound s = Array.Find(sounds, sound => sound.name == name);

        // Si el juego está pausado, reduce la velocidad del sonido a la mitad
        if (PauseMenu.GameIsPaused)
        {
            s.source.pitch *= 0.5f;
        }

        // Reproduce el sonido
        s.source.Play();
    }
}
