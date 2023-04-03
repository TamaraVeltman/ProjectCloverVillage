using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Video : MonoBehaviour
{
    public Slider qualitySlider;
    public float brightness = 1.0f;
    private Material material;

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
    }

    public void Start()
    { 

    }

    public void Update()
    {
        
    }
}
