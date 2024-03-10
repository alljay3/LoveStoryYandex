using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    [SerializeField] private int NheatStart = 0;
    [SerializeField] GameObject Men;
    [SerializeField] GameObject Wooman;
    [SerializeField] GameObject WinUI, LoseUI;
    void Start()
    {
        StateLevel.NHears = NheatStart;
    }

    // Update is called once per frame
    void Update()
    {
        
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
            Debug.Log(i);
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
            Debug.Log(i);
        }
        foreach (GameObject i in Latch)
        {
            Destroy(i);
        }
        LoseUI.GetComponent<LoseMenu>().callLoseMenu();
    }
}
