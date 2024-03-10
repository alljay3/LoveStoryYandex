using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    private float SpawnTimeHeart = 2f;
    [SerializeField] private float CloudSpeed = 2.0f;
    [SerializeField] private GameObject HeartPrefab;
    bool _end = false;
    
    void Start()
    {
        CloudSpeedChange();
        StartCoroutine(SpawnHeart());
    }

    public void End()
    {
        _end = true;
    }

    IEnumerator SpawnHeart()
    {
        while (!_end)
        {
            yield return new WaitForSeconds(Random.Range(SpawnTimeHeart - 1, SpawnTimeHeart + 1));
            if (_end)
                yield break;
            Vector3 p = transform.position;
            p.z -= 2;
            GameObject heart = Instantiate(HeartPrefab, p, Quaternion.identity) as GameObject;
            Vector3 rotate = heart.transform.eulerAngles;
            rotate.x = -90;
            heart.transform.rotation = Quaternion.Euler(rotate);
        }
    }

    public void CloudSpeedChange()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-1 * Random.Range(CloudSpeed - 0.5f, CloudSpeed + 0.5f), 0, 0);
    }

}
