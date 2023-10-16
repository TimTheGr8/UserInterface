using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    private Slider _volumeSlider;
    [SerializeField]
    private AudioMixer _mixer;
    [SerializeField]
    private Slider _brightnessSlider;
    [SerializeField]
    private Image _overlay;

    public void ChangeBrightness()
    {
        var tempColor = _overlay.color;
        tempColor.a = _brightnessSlider.value;
        _overlay.color = tempColor;
    }

    public void AdjustVolume()
    {
        _mixer.SetFloat("BG_Music", _volumeSlider.value);
    }
}
