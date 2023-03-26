using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSettings : MonoBehaviour
{
    public GameObject menu;
    public bool ismenuopen;

    void Start()
    {
        menu.SetActive(false);
        ismenuopen = false;
        //hierdoor staat het menu vanaf het begin uit.

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            //Als ESC word ingedrukt.
        {
            menu.SetActive(!menu.activeSelf);
            //Menu gaat open als je ESC indrukt.
        }
    }

}
