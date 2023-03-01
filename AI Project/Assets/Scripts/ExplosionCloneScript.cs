using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionCloneScript : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2f);
    }
    
}
