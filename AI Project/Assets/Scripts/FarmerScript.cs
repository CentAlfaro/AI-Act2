using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FarmerScript : MonoBehaviour
{
    private NavMeshAgent agent;

    public Transform resourceSpot, spawnPoint;

    [SerializeField] private string resourcePointName, spawnPointName;

    private bool GotResource;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = resourceSpot.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(resourcePointName))
        {
            GotResource = true;
            gameObject.tag = "Farmed";
            agent.destination = spawnPoint.position;
        }

        if (GotResource)
        {
            if (other.CompareTag(spawnPointName))
            {
                Destroy(gameObject);
            }
        }
    }
}
