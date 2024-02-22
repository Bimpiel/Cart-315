using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float rate;
    public GameObject[] enemies;
    public int waves = 2;

    public bool gameStarted = false;

    void Start()
    {
       
    }

    void Update()
    {
        if (!gameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    void StartGame()
    {
        gameStarted = true;
        InvokeRepeating("SpawnEnemy", rate, rate);
    }

    void SpawnEnemy()
    {
        if (gameStarted)
        {
            for (int i = 0; i < waves; i++)
            {
                Instantiate(enemies[(int)Random.Range(0, enemies.Length)], new Vector3(Random.Range(-8.5f, 8.5f), 7, 0), Quaternion.identity);
            }
        }
    }
}
