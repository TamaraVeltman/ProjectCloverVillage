using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsTest : MonoBehaviour
{
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        i = PlayerPrefs.GetInt("Jump");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            PlayerPrefs.SetInt("Jump", 10);
        }
    }
}
