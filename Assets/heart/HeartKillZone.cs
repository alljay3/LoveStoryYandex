using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartKillZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Heart")
        {
            Destroy(other.gameObject);
        }
    }
}

