using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    public AudioMixer masterMixer;

    public void SetMusicVolume(float newVolume)
    {
        masterMixer.SetFloat("musicVolume", newVolume);
    }

    public void SetEnvironmentVolume(float newVolume)
    {
        masterMixer.SetFloat("EnvironmentVolume", newVolume);
    }

    public void SetMasterVolume(float newVolume)
    {
        masterMixer.SetFloat("masterVolume", newVolume);
    }
}
