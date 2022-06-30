using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
	public float startSpeed = 10f;

	[HideInInspector]
	public float speed;

	public float startHealth = 100;
	public float health;

	public int worth = 50;

	public GameObject deathEffect;

	[Header("Unity Stuff")]
	public Image healthBar;

	private bool isDead = false;
	public bool hasDot;

	void Start()
	{
		speed = startSpeed;
		health = startHealth;
	}

	public void TakeDamage(float amount)
	{
		print("Doing damg!");
		healthBar.fillAmount = health / startHealth;
		
		health -= amount;


		if (health <= 0 && !isDead)
		{
			Die();
		}
	}
	public IEnumerator DamageOverTime(float dotDuration,float dotDamgPerTick, GameObject bullet)
	{
		hasDot = true;
		float dotTimer = 0;
		print("Starting Dot");
		Debug.Log(dotDuration);
		while (dotTimer < dotDuration)
		{
			dotTimer += 1;
			TakeDamage(dotDamgPerTick);
			print("Doing dot damg!! with timer of : " + dotTimer.ToString());
			yield return new WaitForSeconds(1);
		}
		hasDot = false;
	}

	public void Slow(float pct)
	{
		speed = startSpeed * (1f - pct);
	}


	void Die()
	{
		isDead = true;

		PlayerStats.Money += worth;

		GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(effect, 5f);

		WaveSystem.EnemiesAlive--;

		Destroy(gameObject);
	}

}
