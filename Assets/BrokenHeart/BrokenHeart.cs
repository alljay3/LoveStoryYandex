using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenHeart : MonoBehaviour
{
    [SerializeField] GameObject BrokenHeartPrefab;
    [SerializeField] LockSpawn LockSpawnScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Heart")
        {
            StartCoroutine(IEBrokenHert(other));
        }
    }

    IEnumerator IEBrokenHert(Collider other)
    {
        Vector3 p = other.transform.position;
        p.x += 0.5f;
        GameObject brokenHeart = GameObject.Instantiate(BrokenHeartPrefab, p, Quaternion.identity) as GameObject;
        Destroy(other.gameObject);
        LockSpawnScript.lockSpawn();
        yield return new WaitForSeconds(0.6f);
        Destroy(brokenHeart);
    }
}
