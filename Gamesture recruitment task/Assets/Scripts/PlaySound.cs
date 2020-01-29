using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField] private SoundScriptableObject sound;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("Can't find AudioSource component",audioSource);
        }
        if (sound == null)
        {
            Debug.LogError("Sound don't added",sound);
        }
    }

    public void PlaySoundOnButtonClick()
    { 
        SetUpAudioToPlay(sound);
        audioSource.Play();
    }

    void SetUpAudioToPlay(SoundScriptableObject sound)
    {
        audioSource.clip = sound.clip;
        audioSource.volume = sound.volume;
    }
}
