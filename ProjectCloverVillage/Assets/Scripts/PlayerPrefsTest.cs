using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("testInt", 10);
        PlayerPrefs.SetString("testString", "Lalalalalala");
        PlayerPrefs.SetInt("audioVolume", 5);

        if (PlayerPrefs.HasKey("audioVolume"))
        {
            // ja dit is het geval.
        }
        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
