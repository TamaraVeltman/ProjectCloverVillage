using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTest : MonoBehaviour
{
    public RaycastHit hit;
    void Start()
    {

    }

    void Update()
    {
        //De Raycast staat op de huidige positie van het object en word naar voren gericht, out zorgt ervoor datde informatie van de raycast word
        //opgeslagen in hit (public RaycastHit hit;), de afstand dat de Raycast is 1000.
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1000))
        {
            //Als je met de raycast een object aan raakt genaamd "Object 2" kan je met E het object oppaken (Volgende regels code).
            if (hit.transform.name == "Object 2")
            {
               //Als je het goeie object hebt geraakt met de raycast zou je het object nu kunnen oppakken, dit kan je met E doen op je toetsenbord.
                //Het correcte object is Object 2, je kan dus alleen deze "oppaken" met E, de andere kunnen niet gepakt worden.
                if (Input.GetKeyDown(KeyCode.E))
                {
                    //Zodra je het object hebt "opgepakt" word het gameObject gedestroyed.
                    Destroy(hit.transform.gameObject);
                    //Wanneer je het object zowaar hebt opgepakt, word dit in de console geprint, je zou dus nu verder moeten gaan met de quest.
                    print("Continue met de Quest.");
                }

            }

        }
    }
}
