using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class WaveSystem : MonoBehaviour
{

	public static int EnemiesAlive = 0;

	public Wave[] waves;

	public Transform spawnPoint;

	public float timeBetweenWaves = 5f;
	private float countdown = 2f;

	public Text roundsSurvivedtxt;
	public Text livestxt;

	public GameManager gameManager;

	private int waveIndex = 0;

    private void Start()
    {
		EnemiesAlive = 0;
    }
    void Update()
	{
		livestxt.text = PlayerStats.Lives.ToString() + " Lives";

		if (OptionsUI.wantOptions == true)
			return;

		if (EnemiesAlive > 0)
		{
			return;
		}

		if (waveIndex == waves.Length)
		{
			gameManager.WinLevel();
			this.enabled = false;
		}

		roundsSurvivedtxt.text = PlayerStats.Rounds.ToString() + "/" + waves.Length.ToString();
		

		if (EnemiesAlive <= 0)
		{
			StartCoroutine(SpawnWave());
			return;
		}

	}

	IEnumerator SpawnWave()
	{
		PlayerStats.Rounds++;

		Wave wave = waves[waveIndex];

		EnemiesAlive = wave.count;

		for (int i = 0; i < wave.count; i++)
		{
			SpawnEnemy(wave.enemy);
			yield return new WaitForSeconds(1f / wave.rate);
		}

		waveIndex += 1;
	}

	void SpawnEnemy(GameObject enemy)
	{
		Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
	}

}