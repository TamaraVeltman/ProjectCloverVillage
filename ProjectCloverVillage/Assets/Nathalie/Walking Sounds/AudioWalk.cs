using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioWalk : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // Krijg de AudioSource-component van de speler
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Als de speler beweegt, speel het geluid af
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        // Als de speler stopt met bewegen, stop het geluid
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
