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
            //laad nieuwe scene in, huidig scene + 1 bij opgetelt om naar de volgende scene te gaan en dat word dan de huidige scene.

    }

    public void QuitGame ()
    {
        Debug.Log("Quit");
        //testen of het werkt
        Application.Quit();
        // Hiermee sluit je de game af
    }
}
