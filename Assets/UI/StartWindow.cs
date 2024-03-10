using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWindow : MonoBehaviour
{
    [SerializeField] AudioSource[] AudioSourceObjs;
    void Start()
    {
        StateLevel.IsGamePause = true;
        Time.timeScale = 0;
        
        Add.Show();

        foreach (AudioSource i in AudioSourceObjs)
        {
            i.enabled = false;
        }

    }

    public void StartGame()
    {
        StateLevel.IsGamePause = false;
        foreach (AudioSource i in AudioSourceObjs)
        {
            i.enabled = true;
        }
        Time.timeScale = 1;
        GameObject.FindGameObjectWithTag("UISound").GetComponent<AudioSource>().Play();
        gameObject.SetActive(false);
    }
}
