using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wooman : MonoBehaviour
{
    public void Win()
    {
        gameObject.GetComponent<Animator>().Play("Base Layer.Kiss");
    }

    public void Lose()
    {
        gameObject.GetComponent<Animator>().Play("Base Layer.WinDance");
    }
}
