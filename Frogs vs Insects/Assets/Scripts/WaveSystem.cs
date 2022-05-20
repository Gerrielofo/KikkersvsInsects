using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSystem : MonoBehaviour
{
    public Transform insect;
    public Transform spawnpoint;
    public float timeBetweenWaves = 5f;
    public float countdown = 2f;

    public Text waveCountdownText;

    public int[,] waveSpawn = new int[30, 30];
    private int waveCount = 0;
    
    void Start()
    {
        
    }

    void Update()
    {
        if(countdown <= 0)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            
        }
        
        countdown -= Time.deltaTime;

        waveCountdownText.text = Mathf.Round(countdown).ToString();
    }
    IEnumerator SpawnWave()
    {
        waveCount += 1;

        for (int i = 0; i < waveCount; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(1f);
        }

    }
    void SpawnEnemy()
    {
        Instantiate(insect, spawnpoint.position, spawnpoint.rotation);
    }
}
