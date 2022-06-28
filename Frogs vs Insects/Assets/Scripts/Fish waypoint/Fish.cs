using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField]
    Transform[] waypoints;
    
    [SerializeField]
    public float moveSpeed = 2f;

    int waypointsIndex = 0;
    public GameObject fish;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[waypointsIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointsIndex].transform.position, moveSpeed * Time.deltaTime);
        
        if(transform.position == waypoints[waypointsIndex].transform.position)
        {
            transform.LookAt(waypoints[waypointsIndex].position);
            waypointsIndex += 1;
        }
       
        if(waypointsIndex == waypoints.Length)
        {
            waypointsIndex = 0;
            
            
        }
            
    }

}
