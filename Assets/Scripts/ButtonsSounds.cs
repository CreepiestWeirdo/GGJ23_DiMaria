using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonsSounds : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler
{
    [SerializeField] AudioClip OnMouseDownSound;
    [SerializeField] AudioClip OnMouseEnterSound;
    AudioSource myAudioSource;

    private void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        myAudioSource.clip = OnMouseDownSound;
        myAudioSource.Play();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        myAudioSource.clip = OnMouseEnterSound;
        myAudioSource.Play();
    }
}
