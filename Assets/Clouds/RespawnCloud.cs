using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCloud : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Cloud")
        {
            Debug.Log(other.tag);
            other.gameObject.transform.position = new Vector3(12, Random.Range(2.5f, 3.5f), -2);
            other.gameObject.GetComponent<Cloud>().CloudSpeedChange();
        }
    }
}
