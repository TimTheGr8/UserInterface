using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PianoKey : MonoBehaviour
{
    [SerializeField]
    private AudioClip _keyClip;
    [SerializeField]
    private AudioSource _audioSource;
    [SerializeField]
    private float _pitch = 1;

    public void PlayKey()
    {
        _audioSource.pitch = _pitch;
        _audioSource.PlayOneShot(_keyClip);
    }
}
