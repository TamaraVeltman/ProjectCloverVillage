using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screenswitcher : MonoBehaviour
{
    public GameObject Loadingscreen;
    public GameObject MainMenu;
    public float switchTime = 5f;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(switchTime);
        Loadingscreen.SetActive(false);
        MainMenu.SetActive(true);
    }

}
