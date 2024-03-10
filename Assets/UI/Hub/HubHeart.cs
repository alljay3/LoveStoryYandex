using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HubHeart : MonoBehaviour
{
    TMPro.TextMeshProUGUI NHeartText;
    // Start is called before the first frame update


    private void Start()
    {
        NHeartText = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        NHeartText.text = StateLevel.NHears.ToString();
    }
}
