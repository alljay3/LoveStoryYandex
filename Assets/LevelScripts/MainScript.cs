using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    [SerializeField] private int NheatStart = 0;
    [SerializeField] private int HeartClick = 1;
    [SerializeField] GameObject Men;
    [SerializeField] GameObject Wooman;
    [SerializeField] GameObject WinUI, LoseUI;
    static public int SHeartClick = 1;
    void Start()
    {
        StateLevel.NHears = NheatStart;
        SHeartClick = HeartClick;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnApplicationFocus(bool hasFocus)
    {
        Silence(!hasFocus);
    }

    void OnApplicationPause(bool isPaused)
    {
        Silence(isPaused);
    }

    private void Silence(bool silence)
    {
        AudioListener.pause = silence;
        // Or / And
        AudioListener.volume = silence ? 0 : 1;
    }

    public void Win()
    {
        Men.GetComponent<Men>().Win();
        Wooman.GetComponent<Wooman>().Win();
        GameObject [] Clouds = GameObject.FindGameObjectsWithTag("Cloud");
        GameObject LockSpawner = GameObject.FindGameObjectWithTag("LockSpawner");
        GameObject[] Hearts = GameObject.FindGameObjectsWithTag("Heart");
        GameObject[] Latch = GameObject.FindGameObjectsWithTag("Latch");
        foreach (GameObject i in Clouds)
        {
            i.GetComponent<Cloud>().End();
        }
        Destroy(LockSpawner);
        foreach (GameObject i in Hearts)
        {
            Destroy(i);
        }
        foreach (GameObject i in Latch)
        {
            Destroy(i);
        }
        WinUI.GetComponent<WinMenu>().callWinMenu();
    }
    public void Lose()
    {
        Men.GetComponent<Men>().Lose();
        Wooman.GetComponent<Wooman>().Lose();
        GameObject[] Clouds = GameObject.FindGameObjectsWithTag("Cloud");
        GameObject LockSpawner = GameObject.FindGameObjectWithTag("LockSpawner");
        GameObject[] Hearts = GameObject.FindGameObjectsWithTag("Heart");
        GameObject[] Latch = GameObject.FindGameObjectsWithTag("Latch");
        foreach (GameObject i in Clouds)
        {
            i.GetComponent<Cloud>().End();
        }
        Destroy(LockSpawner);
        foreach (GameObject i in Hearts)
        {
            Destroy(i);
        }
        foreach (GameObject i in Latch)
        {
            Destroy(i);
        }
        LoseUI.GetComponent<LoseMenu>().callLoseMenu();
    }
}
