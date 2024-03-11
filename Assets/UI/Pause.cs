using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0;
        GameObject.FindGameObjectWithTag("UISound").GetComponent<AudioSource>().Play();
        StateLevel.IsGamePause = true;
    }

    public void ResumeGame()
    {
        StateLevel.IsGamePause = false;
        Time.timeScale = 1;
        GameObject.FindGameObjectWithTag("UISound").GetComponent<AudioSource>().Play();
        gameObject.SetActive(false);
    }
    public void CallPause()
    {
        Time.timeScale = 0;
        GameObject.FindGameObjectWithTag("UISound").GetComponent<AudioSource>().Play();
        gameObject.SetActive(true);
    }
    public void Restart()
    {
        GameObject.FindGameObjectWithTag("UISound").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel(string namescene)
    {
        GameObject.FindGameObjectWithTag("UISound").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(namescene);
    }
}
