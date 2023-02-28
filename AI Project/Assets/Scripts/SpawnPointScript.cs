using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointScript : MonoBehaviour
{
    private FarmerScript farmerScript;
    private Transform spawnPos;
    [SerializeField] private GameObject[] farmers;
    [SerializeField] private Transform[] resourceSpots;

    private void Start()
    {
        spawnPos = transform;
    }
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
           GameObject go = Instantiate(farmers[0], transform.position, Quaternion.identity) as GameObject;
           go.GetComponent<FarmerScript>().resourceSpot = resourceSpots[0];
           go.GetComponent<FarmerScript>().spawnPoint = spawnPos;
        }

        if (Input.GetKeyDown("2"))
        {
            GameObject go = Instantiate(farmers[1], transform.position, Quaternion.identity) as GameObject;
            go.GetComponent<FarmerScript>().resourceSpot = resourceSpots[1];
            go.GetComponent<FarmerScript>().spawnPoint = spawnPos;
        }

        if (Input.GetKeyDown("3"))
        {
            GameObject go = Instantiate(farmers[2], transform.position, Quaternion.identity) as GameObject;
            go.GetComponent<FarmerScript>().resourceSpot = resourceSpots[2];
            go.GetComponent<FarmerScript>().spawnPoint = spawnPos;
        }

        if (Input.GetKeyDown("4"))
        {
            GameObject go = Instantiate(farmers[3], transform.position, Quaternion.identity) as GameObject;
            go.GetComponent<FarmerScript>().resourceSpot = resourceSpots[3];
            go.GetComponent<FarmerScript>().spawnPoint = spawnPos;
        }
    }
}
