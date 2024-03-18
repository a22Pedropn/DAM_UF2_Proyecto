using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    // Puntos de spawn donde se generan los bloques
    public Transform[] spawnPoints;

    // Prefabs de los bloques que se pueden generar
    public GameObject[] prefab;

    // Tiempo entre generación de bloques
    public float timetospawn = 2f;

    // Variable de tiempo
    public float t = 2f;

    // Matriz que define los patrones de generación de bloques
    public int[,] pos = new int[,] { 
		{5,4,3,0,1,2},
		{5,0,0,3,0,0},
		{5,3,0,4,5,0},
		{5,4,0,4,1,0},
		{5,3,1,6,7,8},
		{5,3,1,9,10,2},
		{5,1,0,9,2,0},
		{5,2,3,11,3,12},
		{5,4,0,4,13,0},
		{5,0,0,4,0,0},
		{6,0,0,3,0,0},
		{6,0,0,4,0,0},
		{6,3,0,11,12,0},
		{6,2,0,14,3,0},
		{6,1,0,14,15,0},
		{2,0,0,16,0,0},
		{4,0,0,17,0,0},
		{1,4,0,18,19,0},
		{1,2,0,2,20,0},
		{2,0,0,20,0,0}
	                                    };

    // Se llama en cada cuadro de actualización del juego
    void Update()
    {
        // Verifica si es el momento de generar bloques
        if (Time.time >= timetospawn)
        {
            // Llama al método SpawnBlocks para generar bloques
            SpawnBlocks();

            // Actualiza el tiempo para la próxima generación
            timetospawn = Time.time + t;
        }
    }

    // Método para generar bloques
    void SpawnBlocks()
    {
        // Elige un tipo de generación aleatoria (random1)
        int random1 = Random.Range(0, 3);

        // Elige un patrón de generación aleatorio (random2)
        int random2 = Random.Range(0, 20);

        // Genera bloques según el tipo de generación aleatoria
        if (random1 == 0)
        {
            // Genera bloques en los puntos de spawn definidos en el patrón de generación
            for (int i = 0; i < 3; i++)
            {
                if (pos[random2, i] != 0)
                {
                    Instantiate(prefab[pos[random2, i] - 1], spawnPoints[pos[random2, i + 3] + 21].position, Quaternion.identity);
                }
            }
        }
        else if (random1 == 1)
        {
            // Genera bloques en los puntos de spawn definidos en el patrón de generación
            for (int i = 0; i < 3; i++)
            {
                if (pos[random2, i] != 0)
                {
                    Instantiate(prefab[pos[random2, i] - 1], spawnPoints[pos[random2, i + 3]].position, Quaternion.identity);
                }
            }
        }
        else if (random1 == 2)
        {
            // Elige otro patrón de generación aleatorio (random3)
            int random3 = Random.Range(0, 20);

            // Genera bloques según el patrón de generación aleatorio (random3)
            for (int i = 0; i < 3; i++)
            {
                if (pos[random3, i] != 0)
                {
                    Instantiate(prefab[pos[random3, i] - 1], spawnPoints[pos[random3, i + 3] + 21].position, Quaternion.identity);
                }
            }

            // Genera bloques según el patrón de generación aleatorio (random2)
            for (int i = 0; i < 3; i++)
            {
                if (pos[random2, i] != 0)
                {
                    Instantiate(prefab[pos[random2, i] - 1], spawnPoints[pos[random2, i + 3]].position, Quaternion.identity);
                }
            }
        }
    }
}

