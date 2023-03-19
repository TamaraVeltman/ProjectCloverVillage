using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //Hiermee laat je de eerst volgende scene.

    }

    public void Quitgame ()
    {
        Debug.Log("Quit");
        //testen of het werkt
        Application.Quit();
        // Hiermee sluit je de game af
    }
}
