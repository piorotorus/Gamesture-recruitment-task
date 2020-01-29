using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(fileName ="New Sound",menuName = "Sound")]
public class SoundScriptableObject : ScriptableObject
{
    public new string name;
    public AudioClip clip;
    [Range(0f,1f)]
    public float volume;
}
