using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstScene : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefs.GetInt("start") == 0)
        {
            SceneManager.LoadScene("level1");
        }
        else if (PlayerPrefs.GetInt("start") == 1)
        {
            SceneManager.LoadScene("level2");
        }
        else if (PlayerPrefs.GetInt("start") == 2)
        {
            SceneManager.LoadScene("level3");
        }
        else
        {
            SceneManager.LoadScene("level1");
        }

    }
}
