using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private AudioSource audioSource;
    public static MusicManager _instance;

    private readonly float defaultVolume = 1f;

    private float currentMusicValue = 1f;
    private float currentSFXValue = 1f;

    public AudioClip GameplayMusic;
    public AudioClip IntroMusic;

    public float GetMusicValue()
    {
        return currentMusicValue;
    }

    public float GetSFXValue()
    {
        return currentSFXValue;
    }

    public void SetMusicValue(float value)
    {        
        audioSource.volume = value * value;
        currentMusicValue = value;
    }

    public void SetSFXValue(float value)
    {
        currentSFXValue = value;            
    }

    private void Awake()
    {
        if(_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
    }

    public void SetMusic(AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    public string GetMusicName()
    {
        return audioSource.clip.name;
    }

    public void ResetVolume()
    {
        currentMusicValue = defaultVolume;
        currentSFXValue = defaultVolume;
    }
}
