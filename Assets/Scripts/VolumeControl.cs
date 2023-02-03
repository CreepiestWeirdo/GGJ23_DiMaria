using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    [SerializeField] Slider MusicSlider;
    [SerializeField] Slider SFXSlider;
    [SerializeField] AudioSource Music;

    private readonly float defaultVolume = 1f;

    private float currentMusicValue = 1f;
    private float currentSFXValue = 1f;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public void ChangeMusicValue()
    {
        currentMusicValue = MusicSlider.value * MusicSlider.value;
        Music.volume= currentMusicValue;
    }

    public void ChangeSFXValue()
    {
        currentSFXValue = SFXSlider.value * SFXSlider.value;
    }

    public void ResetVolumeValues()
    {
        currentMusicValue = defaultVolume;
        currentSFXValue = defaultVolume;
    }
}
