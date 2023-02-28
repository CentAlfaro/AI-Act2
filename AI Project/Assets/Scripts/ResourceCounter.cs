using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceCounter : MonoBehaviour
{
    private int coinsCounted;
    [SerializeField] private TextMeshProUGUI coinCounter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Farmed"))
        {
            coinsCounted += 1;
            coinCounter.text = coinsCounted.ToString();
        }
    }


}
