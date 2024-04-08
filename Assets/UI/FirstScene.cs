using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FirstScene : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI TextLoad;
    private void Start()
    {
        if (PlayerPrefs.GetInt("start") == 0)
        {
            SceneManager.LoadSceneAsync("level1");
        }
        else if (PlayerPrefs.GetInt("start") == 1)
        {
            SceneManager.LoadSceneAsync("level2");
        }
        else if (PlayerPrefs.GetInt("start") == 2)
        {
            SceneManager.LoadSceneAsync("level3");
        }
        else
        {
            SceneManager.LoadSceneAsync("level1");
        }
        StartCoroutine(Tochka());
        
    }
    IEnumerator Tochka()
    {
        while (true)
        {
            TextLoad.text = "Загрузка .";
            yield return new WaitForSeconds(0.2f);
            TextLoad.text = "Загрузка . .";
            yield return new WaitForSeconds(0.2f);
            TextLoad.text = "Загрузка . . .";
            yield return new WaitForSeconds(0.2f);
        }
    }
}
