using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseLine : MonoBehaviour
{
    [SerializeField] private MainScript Main;
    [SerializeField] AudioClip Clip;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Men")
        {
            Main.GetComponent<MainScript>().Lose();
            GameObject.FindGameObjectWithTag("OtherSound").GetComponent<AudioSource>().clip = Clip;
            GameObject.FindGameObjectWithTag("OtherSound").GetComponent<AudioSource>().Play();
        }
    }
}
