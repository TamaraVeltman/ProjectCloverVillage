using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetPlayerPositionNewGame : MonoBehaviour
{
    public GameObject player;
    public Vector3 startingposition;
   
   

    void Start()
    {
        startingposition = player.transform.position;
        //sla de startpositie van de player op.
        Button Newgame = GetComponent<Button>();
        //geef aan welke knop je wil gebruiken.
        Newgame.onClick.AddListener(ResetPlayerPosition);
        //geef aan dat als je op de knop klikt dit moet worden uitgevoerd.
        
    }

    void ResetPlayerPosition()
    {
        player.transform.position = startingposition;
        //als er op de knop word geklikt word dit uitgevoerd waardoor de game reset naar startpositie.
    }
}
