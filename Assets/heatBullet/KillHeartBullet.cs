using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillHeartBullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "HeartBullet")
        {
            Destroy(other.gameObject);
        }
    }
}
