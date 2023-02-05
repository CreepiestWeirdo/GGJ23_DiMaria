using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    [SerializeField] Slider MusicSlider;
    [SerializeField] Slider SFXSlider;

    private void Start()
    {
        MusicSlider.value = MusicManager._instance.GetMusicValue();
       // SFXSlider.value = MusicManager._instance.GetSFXValue();        
    }
    public void ChangeMusicValue()
    {
        MusicManager._instance.SetMusicValue(MusicSlider.value);
    }

    public void ChangeSFXValue()
    {
       // MusicManager._instance.SetSFXValue(SFXSlider.value);
    }
}
