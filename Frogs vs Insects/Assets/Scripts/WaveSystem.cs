using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSystem : MonoBehaviour
{

	public static int EnemiesAlive = 0;

	public Wave[] waves;

	public Transform spawnPoint;

	public float timeBetweenWaves = 5f;
	private float countdown = 2f;

	public Text waveCountdownText;

	public GameManager gameManager;

	private int waveIndex = 0;

	void Update()
	{
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

		if (EnemiesAlive <= 0)
		{
			StartCoroutine(SpawnWave());
			return;
		}

		waveCountdownText.text = waveIndex.ToString() + "/30";
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

		waveIndex++;
	}

	void SpawnEnemy(GameObject enemy)
	{
		Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
		EnemiesAlive++;
	}

}