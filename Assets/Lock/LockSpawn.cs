using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockSpawn : MonoBehaviour
{
    [SerializeField] GameObject LockPrefab;
    [SerializeField] float DefaultSpeed;
    [SerializeField] float DefaultTimeSpawn;
    [SerializeField] float TimeReduce = 20;
    [SerializeField] float WeithReuce = 0.05f;
    [SerializeField] float TimeLimit = 0.3f;
    private float _timeSpawn;
    void Start()
    {
        _timeSpawn = DefaultTimeSpawn;
        StartCoroutine(IESpawnLock());
        StartCoroutine(IETime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator IETime()
    {
        while (_timeSpawn > TimeLimit)
        {
            yield return new WaitForSeconds(TimeReduce);
            _timeSpawn -= WeithReuce;
        }
    }

    IEnumerator IESpawnLock()
    {
        while(true)
        {
            lockSpawn();
            yield return new WaitForSeconds(_timeSpawn);
        }
    }

    public void lockSpawn()
    {
        GameObject myLock = GameObject.Instantiate(LockPrefab, transform.position, Quaternion.identity) as GameObject;
        myLock.GetComponent<Lock>().Speed = DefaultSpeed;
        Vector3 rotate = myLock.transform.eulerAngles;
        rotate.x = -90;
        rotate.z = -90;
        myLock.transform.rotation = Quaternion.Euler(rotate);
    }
}
