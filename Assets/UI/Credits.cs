using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public void StartCredits()
    {
        GameObject.FindGameObjectWithTag("UISound").GetComponent<AudioSource>().Play();
        gameObject.SetActive(true);
    }
    public void CloseCredits()
    {
        GameObject.FindGameObjectWithTag("UISound").GetComponent<AudioSource>().Play();
        gameObject.SetActive(false);
       
    }
}
