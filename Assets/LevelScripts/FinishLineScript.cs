using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineScript : MonoBehaviour
   
{
    [SerializeField] private MainScript Main;
    [SerializeField] private GameObject HeartPrefab;
    [SerializeField] AudioClip Clip;

    private void Start()
    {
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Men")
        {
            Main.GetComponent<MainScript>().Win();
            StartCoroutine(LoveLove());
        }
    }

    IEnumerator LoveLove()
    {
        Vector3 p = transform.position;
        p.y += 0.7f;
        yield return new WaitForSeconds(1.4f);
        GameObject.FindGameObjectWithTag("OtherSound").GetComponent<AudioSource>().clip = Clip;
        GameObject.FindGameObjectWithTag("OtherSound").GetComponent<AudioSource>().Play();
        GameObject love1 = GameObject.Instantiate(HeartPrefab, p, Quaternion.identity) as GameObject;
        love1.GetComponent<HeartLove>().ChangeSpeed(new Vector3(0, 1, 0));
        yield return new WaitForSeconds(0.2f);
        GameObject love2 = GameObject.Instantiate(HeartPrefab, p, Quaternion.identity) as GameObject;
        love2.GetComponent<HeartLove>().ChangeSpeed(new Vector3(0.5f, 1, 0));
        yield return new WaitForSeconds(0.2f);
        GameObject love3 = GameObject.Instantiate(HeartPrefab, p, Quaternion.identity) as GameObject;
        love3.GetComponent<HeartLove>().ChangeSpeed(new Vector3(-0.5f, 1, 0));
        yield return new WaitForSeconds(0.2f);
        GameObject love4 = GameObject.Instantiate(HeartPrefab, p, Quaternion.identity) as GameObject;
        love4.GetComponent<HeartLove>().ChangeSpeed(new Vector3(0.25f, 1, 0));
        yield return new WaitForSeconds(0.2f);
        GameObject love5 = GameObject.Instantiate(HeartPrefab, p, Quaternion.identity) as GameObject;
        love5.GetComponent<HeartLove>().ChangeSpeed(new Vector3(-0.25f, 1, 0));
        yield return new WaitForSeconds(0.7f);
        Destroy(love1);
        yield return new WaitForSeconds(0.2f);
        Destroy(love2);
        yield return new WaitForSeconds(0.2f);
        Destroy(love3);
        yield return new WaitForSeconds(0.1f);
        Destroy(love4);
        yield return new WaitForSeconds(0.1f);
        Destroy(love5);
    }
}
