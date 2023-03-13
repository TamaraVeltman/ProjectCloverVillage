using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //De "afstand" die de Y as mag/kan bewegen, cosnt betekent dat het niet meer kan veranderen wanneer de code word uitgevoerd
    private const float YMin = 0.0f;
    private const float YMax = 30.0f;

    public Transform lookAt;
    public Transform Player;

    public float distance = 0.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    public float sensivity = 0.0f;

    //LateUpdate zorgt ervoor dat de position en rotation van de camera pas worden bijgewerkt wanneer alle andere objecten in dezelfde scene zijn bijgewerkt
    //dit zorgt ervoor dat de camerabewegingen er beter en soepeler uitzien
    void LateUpdate()
    {
        //currentX/Y houden de horizontale en verticale bewegingen bij die je met je muis maakt
        //GetAxis is tussen -1 en 1 en wilt altijd naar 0, Mouse X en Mouse Y zijn dingen in Unity
        //De sensitivity bepaald de gevoeligheid van de muis, als deze hoger is dan bijvoorbeeld 5 beweegt de muis sneller
        //Time.deltaTime word gebruikt om de rotatiesnelheid te scheiden van de framesnelheid
        currentX += Input.GetAxis("Mouse X") * sensivity * Time.deltaTime;
        currentY += Input.GetAxis("Mouse Y") * sensivity * Time.deltaTime;

        //Mathf voert wiskundige bewerkingen toe op getallen
        //als currentY lager is dan YMin word deze standaard terug gezet naar de waarde van YMin, hetzelfde gebeurt met YMax, dit doet de Clamp functie
        currentY = Mathf.Clamp(currentY, YMin, YMax);

        //De Direction geeft aan welke richting je opkijkt
        //-distance is de z as, het zorgt ervoor dat je achteruit kan kijken
        Vector3 Direction = new Vector3(0, 0, -distance);
        //
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        //lookAt.position + rotation * Direction is de positie waar de camera naartoe moet kijken (naar de positie van het lookAt gameObject)
        transform.position = lookAt.position + rotation * Direction;

        //LookAt is waar de camera naartoe moet kijke (dus de speler bijvoorbeeld)
        transform.LookAt(lookAt.position);
    }
}
