using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    [SerializeField] AudioClip[] AudioClips;
    private void Start()
    {
        GetComponent<AudioSource>().clip = AudioClips[Random.Range(0, AudioClips.Length)];
        GetComponent<AudioSource>().Play();
    }

    private void FixedUpdate()
    {
        if (!GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<AudioSource>().clip = AudioClips[Random.Range(0, AudioClips.Length)];
            GetComponent<AudioSource>().Play();
        }
    }
}
