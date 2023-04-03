using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Video : MonoBehaviour
{
    public Slider qualitySlider;

    public void ToggleFullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
        //met deze code regel toggle je fullscreen of windowedscreen.
    }

    public void SetQuality()
    {
        QualitySettings.SetQualityLevel((int)qualitySlider.value);
        Debug.Log((int)qualitySlider.value);
        //Veranderd de quality van de game met een slider 0 = Performant, 1 = Balanced, 2 = High fidelity.
        //Debug is om te laten zien dat hij werkt
    }
}
