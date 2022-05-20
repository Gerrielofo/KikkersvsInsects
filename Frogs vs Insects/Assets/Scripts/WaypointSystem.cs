using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointSystem : MonoBehaviour
{
    public Transform[] waypoints;
    public float moveSpeed = 2f;
    public int waypointIndex = 0;

    void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }

    void Update()
    {
        Move();
    }
    public void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

        if(transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex += 1;
            transform.LookAt(waypoints[waypointIndex]);
        }
        if(waypointIndex == waypoints.Length)
        {
            Destroy(this.gameObject);
        }
    }
}
