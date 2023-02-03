using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private AudioSource musicManager;

    private void Awake()
    {
        musicManager= GetComponent<AudioSource>();
    }

    public void ChangeMusic(AudioClip audioClip)
    {
        musicManager.clip= audioClip;
        musicManager.Play();
    }
}
