using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSettings : MonoBehaviour
{
    public GameObject menu;
    
    void Start()
    {
        menu.SetActive(false);
        //hierdoor staat het menu vanaf het begin uit.

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            //hier geef je aan dat je de knop ESC wil gebruiken.
        {
 
            menu.SetActive(!menu.activeSelf);
            //als je ESC indrukt gaat het menu in beeld.
 
        }
    }

    

}
