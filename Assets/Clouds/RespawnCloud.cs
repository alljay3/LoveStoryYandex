using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCloud : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cloud")
        {
            other.gameObject.transform.position = new Vector3(12, Random.Range(2.5f, 3.5f), -2);
            other.gameObject.GetComponent<Cloud>().CloudSpeedChange();
        }
    }
}
