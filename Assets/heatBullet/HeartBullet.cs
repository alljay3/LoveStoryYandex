using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBullet : MonoBehaviour
{
    [SerializeField] float HeartSpeed;
    public Vector3 _rotor = new Vector3(0, 1f, 0);
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(HeartSpeed, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Latch")
        {
            Destroy(other.gameObject);
            //other.gameObject.GetComponent<Lock>().dead();
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        transform.eulerAngles += _rotor;
    }
}
