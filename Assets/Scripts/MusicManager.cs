using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private AudioSource audioSource;
    public static MusicManager _instance;
    public static List<AudioSource> sfxList = new List<AudioSource>();

    private readonly float defaultVolume = 1f;

    private float currentMusicValue = 1f;
    private float currentSFXValue = 1f;

    public AudioClip Gameplay;

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

        foreach (var sfx in sfxList)
        {
            sfx.volume = value * value;
        }              
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

            foreach (var sfx in sfxList)
            {
                sfx.volume = GetSFXValue();
            }
        }

        audioSource = GetComponent<AudioSource>();
    }

    public void SetMusic(AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    public string GetMusic()
    {
        return audioSource.clip.name;
    }

    public void ResetVolume()
    {
        currentMusicValue = defaultVolume;
        currentSFXValue = defaultVolume;
    }
}
