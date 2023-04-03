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
        //screen.fullscreen = boolean zonder ! true met ! false, want ! maakt negatief.
    }

    public void SetQuality()
    {
        QualitySettings.SetQualityLevel((int)qualitySlider.value);
        Debug.Log((int)qualitySlider.value);
        //Veranderd de quality van de game met een slider 0 = Performant, 1 = Balanced, 2 = High fidelity.
        //Debug is om te laten zien dat hij werkt
        //SetQualityLevel vraag hele getallen terwijl QualitySlider.value een decimaal is, dus je voegt een int toe om het een heel getal te maken.
        // json of xml
    }
}
