using UnityEngine;
using System.Collections;

[RequireComponent(typeof(EnemyMovement))]
public class WaypointSystem : MonoBehaviour
{
	private Transform target;
	private int wavepointIndex = 0;

	private EnemyMovement enemy;

	void Start()
	{
		enemy = GetComponent<EnemyMovement>();

		target = Waypoint.points[0];
	}

	void Update()
	{
		Vector3 dir = target.position - transform.position;
		transform.Translate(dir.normalized * enemy.speed * Time.deltaTime, Space.World);

		if (Vector3.Distance(transform.position, target.position) <= 0.4f)
		{
			GetNextWaypoint();
		}

		enemy.speed = enemy.startSpeed;
		transform.LookAt(target);
	}

	void GetNextWaypoint()
	{
		if (wavepointIndex >= Waypoint.points.Length - 1)
		{
			EndPath();
			return;
		}

		wavepointIndex++;
		target = Waypoint.points[wavepointIndex];
	}

	void EndPath()
	{
		PlayerStats.Lives--;
		WaveSystem.EnemiesAlive--;
		Destroy(gameObject);
	}

}
