using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAIController : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform[] waypoints;
    private int waypointIndex;
    private Vector3 target;
    
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }


    private void Update()
    {
        if(Vector3.Distance(transform.position, target) < 1 )
        {
            IterateWaypointIndex();
            UpdateDestination();
        }
    }

    private void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    private void IterateWaypointIndex()
    {
        waypointIndex++;
        if(waypointIndex == waypoints.Length)
        {
            waypointIndex = 0; 
        }
    }
}
