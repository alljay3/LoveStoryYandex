using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Men : MonoBehaviour
{
    [SerializeField] private float MenSpeed;
    [SerializeField] private GameObject HeartBulletPrefab;
    [SerializeField] private float SpeedFire;
    [SerializeField] private float XHeart = 0.3f;
    [SerializeField] private float YHeart = 0.8f;
    [SerializeField] AudioClip[] Clips;
    private bool _isCooldownFile = false;
    private bool _end = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(MenSpeed, 0, 0);
        gameObject.GetComponent<Animator>().SetFloat("SpeedWalk", MenSpeed + 0.5f);
        gameObject.GetComponent<Rigidbody>().freezeRotation = true;
        gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        gameObject.GetComponent<Animator>().SetFloat("SpeedCast", 2.2f - SpeedFire);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
            SpawnHeart();
    }

    public void Win()
    {
        _end = true;
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.GetComponent<Animator>().Play("Base Layer.kiss");
        StartCoroutine(TurnBack());
    }

    public void Lose()
    {
        Destroy(gameObject);
    }

    public void ChangeSpeed(int times = 0, float speepUp = 0.1f)
    {
        MenSpeed = MenSpeed + speepUp;
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(MenSpeed, 0, 0);
        gameObject.GetComponent<Animator>().SetFloat("SpeedWalk", MenSpeed + 0.5f);
    }

    public void ChangeSpeedAtack(int times = 0, float speepUp = 0.1f)
    {
        SpeedFire -= speepUp;
        gameObject.GetComponent<Animator>().SetFloat("SpeedCast", 2.2f - SpeedFire);
        Debug.Log(SpeedFire);
    }
   



    public void SpawnHeart()
    {
        if (!_isCooldownFile && StateLevel.NHears > 0 && !_end && !StateLevel.IsGamePause)
            StartCoroutine(IESpawnHeart());
    }

    IEnumerator IESpawnHeart()
    {
        StateLevel.NHears -= 1;
        _isCooldownFile = true;
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.GetComponent<AudioSource>().clip = Clips[0];
        gameObject.GetComponent<AudioSource>().Play();
        gameObject.GetComponent<Animator>().Play("Base Layer.CastHeart", 0, 0);
        yield return new WaitForSeconds(SpeedFire);
        gameObject.GetComponent<AudioSource>().clip = Clips[1];
        gameObject.GetComponent<AudioSource>().Play();
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(MenSpeed, 0, 0);
        Vector3 p = transform.position;
        p.y += YHeart;
        p.x += XHeart;

        GameObject.Instantiate(HeartBulletPrefab, p, Quaternion.identity);
        _isCooldownFile = false;
    }

    IEnumerator TurnBack()
    {
        yield return new WaitForSeconds(3.7f);
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-1.5f, 0, 0);
        yield return new WaitForSeconds(1f);
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.GetComponent<Animator>().Play("Base Layer.MenDance");
    }

    void OnCollisionStay(Collision collision)
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(MenSpeed, 0, 0);
    }
}
