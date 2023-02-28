using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolScript : MonoBehaviour
{
    [SerializeField] private Transform[] patrolPoints;
    [SerializeField] private Transform player;

    private int DestinationPoints;
    [SerializeField] private float stoppingDistance = 0.5f;

    private NavMeshAgent agent;
    [SerializeField] private float radius;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false; // avoids autobraking the agent's path  
    }


    void Update()
    {
        float searchRadius = Vector3.Distance(transform.position, player.position);
        if (!agent.pathPending && agent.remainingDistance < stoppingDistance)
        {
            NextPoint();
        }

        if (radius > searchRadius)
        {
            agent.destination = player.position;
        }
    }

    public void NextPoint()
    {
        if (patrolPoints.Length == 0)
        {
            return;
        }

        agent.destination = patrolPoints[DestinationPoints].position;
        DestinationPoints = (DestinationPoints + 1) % patrolPoints.Length;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
