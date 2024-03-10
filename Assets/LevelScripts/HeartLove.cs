using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartLove : MonoBehaviour
{

    public void ChangeSpeed(Vector3 Speed)
    {
        gameObject.GetComponent<Rigidbody>().velocity = Speed;
    }
}
