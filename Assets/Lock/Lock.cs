using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public float Speed { get; set; }
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(Speed * -1, 0, 0);
        gameObject.GetComponent<Rigidbody>().freezeRotation = true;

    }

    public void dead()
    {
        StartCoroutine(IEDead());
    }

    IEnumerator IEDead()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(Speed * 7, 0, 0);
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}
