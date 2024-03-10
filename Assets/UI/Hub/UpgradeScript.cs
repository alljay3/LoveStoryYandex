
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeScript : MonoBehaviour
{
    [SerializeField] GameObject[] CloudsObj;
    [SerializeField] GameObject[] CatsObj;
    [SerializeField] TMPro.TextMeshProUGUI TextCloud, TextCat, TextSpeed, TextSpeedAtack;
    [SerializeField] Men MenScript;
    [SerializeField] int CostClouds = 15, CostCat = 30, CostSpeed = 10, CostSpeedAtack = 10;
    [SerializeField] int GranClouds = 6, GranCat = 5, GranSpeed = 10, GranAtack = 10;
    int _timeClouds = 1, _timeCats = 1, _timeSpeed = 1, _timeSpeedAtack = 1;

    public void Start()
    {
        TextCloud.text = CostClouds.ToString();
        TextCat.text = CostCat.ToString();
        TextSpeed.text = CostSpeed.ToString();
        TextSpeedAtack.text = CostSpeedAtack.ToString();
    }

    public void BuyCloud()
    {
        if (StateLevel.NHears >= CostClouds * _timeClouds && _timeClouds <= GranClouds)
        {
            GameObject.FindGameObjectWithTag("UpdateSound").GetComponent<AudioSource>().Play();
            StateLevel.NHears -= CostClouds * _timeClouds;
            CloudsObj[_timeClouds - 1].SetActive(true);
            _timeClouds += 1;
            if (_timeClouds <= GranClouds)
                TextCloud.text = (CostClouds * _timeClouds).ToString();
            else
            {
                TextCloud.text = "Нет";
                TextCloud.color = new Color32(152, 60, 11, 255);
            }


        }
    }
    public void BuyCat()
    {
        if (StateLevel.NHears >= CostCat * _timeCats && _timeCats <= GranCat)
        {
            GameObject.FindGameObjectWithTag("UpdateSound").GetComponent<AudioSource>().Play();
            StateLevel.NHears -= CostCat * _timeCats;
            CatsObj[_timeCats - 1].SetActive(true);
            _timeCats += 1;
            if (_timeCats <= GranCat)
                TextCat.text = (CostCat * _timeCats).ToString();
            else
            {
                TextCat.text = "Нет";
                TextCat.color = new Color32(152, 60, 11, 255);
            }


        }
    }

    public void BuySpeed()
    {
        if (StateLevel.NHears >= CostSpeed * _timeSpeed && _timeSpeed <= GranSpeed)
        {
            GameObject.FindGameObjectWithTag("UpdateSound").GetComponent<AudioSource>().Play();
            StateLevel.NHears -= CostSpeed * _timeSpeed;
            MenScript.ChangeSpeed(_timeSpeed,0.1f);
            _timeSpeed += 1;
            if (_timeSpeed <= GranSpeed)
                TextSpeed.text = (CostSpeed * _timeSpeed).ToString();
            else
            {
                TextSpeed.text = "Нет";
                TextSpeed.color = new Color32(152, 60, 11, 255);
            }


        }
    }

    public void BuySpeedAttack()
    {
        if (StateLevel.NHears >= CostSpeedAtack * _timeSpeedAtack && _timeSpeedAtack <= GranAtack)
        {
            GameObject.FindGameObjectWithTag("UpdateSound").GetComponent<AudioSource>().Play();
            StateLevel.NHears -= CostSpeedAtack * _timeSpeedAtack;
            MenScript.ChangeSpeedAtack(_timeSpeedAtack, 0.1f);
            _timeSpeedAtack += 1;
            if (_timeSpeedAtack <= GranAtack)
                TextSpeedAtack.text = (CostSpeedAtack * _timeSpeedAtack).ToString();
            else
            {
                TextSpeedAtack.text = "Нет";
                TextSpeedAtack.color = new Color32(152, 60, 11, 255);
            }


        }
    }

}
