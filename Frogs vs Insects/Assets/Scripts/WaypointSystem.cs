using UnityEngine;
using System.Collections;

[RequireComponent(typeof(EnemyMovement))]
public class WaypointSystem : MonoBehaviour
{
	private Transform target;
	private int waypointindex = 0;

	private EnemyMovement enemy;

	void Start()
	{
		enemy = GetComponent<EnemyMovement>();

		target = Waypoint.points[0];
	}

	void Update()
	{
		if (OptionsUI.wantOptions == true || GameManager.GameIsOver == true)
			return;
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
		if (waypointindex >= Waypoint.points.Length - 1)
		{
			EndPath();
			return;
		}

		waypointindex++;
		target = Waypoint.points[waypointindex];
	}

	void EndPath()
	{
		PlayerStats.Lives--;
		WaveSystem.EnemiesAlive--;
		Destroy(gameObject);
	}

}
