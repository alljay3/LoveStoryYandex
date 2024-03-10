using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatReverse : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cat")
        {
            other.gameObject.GetComponent<Cat>().ChangeSpeed();
        }
    }
}
