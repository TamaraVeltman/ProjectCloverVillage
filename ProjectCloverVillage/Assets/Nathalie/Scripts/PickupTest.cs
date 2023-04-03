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
            //Raycast raatk object met de naam Object 2.
            if (hit.transform.name == "Object 2")
            {
                //Je klikt op het object dat het goede is (dus die met de naam Object 2, in dit geval is dat de sphere) wanneer je dit doet gebeurt de code eronder.
                //Met GetMouseButtonDown zorg je ervoor dat de raycast zelf niet het object al uit zichzelf verwijderd en dat je dit zelf moet doen.
                //De 0 achter GetMouseButtonDown betekent dat je met de linker muisknop moet drukken om er voor te zorgen dat de code werkt die erna komt.
                if (Input.GetMouseButtonDown(0)) // 0 betekent de linker muisknop
                {
                    //Wanneer het object is gezien door de raycast word dit in de console geprint.
                    print("Object opgepakt!");
                    //Als het object word geraakt door de raycast word hij gedetroyed, je hebt hem dan dus een soortvan "opgepakt".
                    Destroy(hit.transform.gameObject);
                }

            }

        }
    }
}
