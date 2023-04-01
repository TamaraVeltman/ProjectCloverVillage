using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Save : MonoBehaviour
{
    public GameObject player;
    public Vector3 prevPosition;

    public void StorePosition()
    {
        PlayerPrefs.SetFloat("x", player.transform.position.x);
        PlayerPrefs.SetFloat("y", player.transform.position.y);
        PlayerPrefs.SetFloat("z", player.transform.position.z);
        //Hiermee sla je de playerposition op.

    }

    public void RestorePosition()
    {
        Vector3 prevPosition = new Vector3();
        prevPosition.x = PlayerPrefs.GetFloat("x"); 
        prevPosition.y = PlayerPrefs.GetFloat("y");
        prevPosition.z = PlayerPrefs.GetFloat("z");
        player.transform.position = prevPosition;
        //hiermee haal je de opgeslagen positie weer op door op continue te klikken.
    }
}
