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
        
    }

   public void ResetPlayerPosition()
    {
        player.transform.position = startingposition;
        //als er op de knop word geklikt word dit uitgevoerd waardoor de game reset naar startpositie.
    }
}
