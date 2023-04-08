using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationTest : MonoBehaviour
{
    public float mouseX;
    public float mouseY;
    public Vector3 playerRot;
    public Vector3 cameraRot;
    public Camera cam;
    
    void Start()
    {

    }

    
    void Update()
    {
        //GetAxis ligt tussen -1 en 1, en die wilt altijd terug naar 0, als je naar links of recht kijkt gaat de waarde omhoog tot -1 of 1, wanneer je stopt met rond kijken is dit weer 0.
        //Bij mouseX word de horizontale beweging van je muis opgeslagen, hetzelfde gebeurt bij mouseY maar dan is het de vertivale beweging.
        //De waarde bij mouseY is negatief gemaakt zodat je naar boven kijkt als je met je muis naar boven gaat en niet naar beneden zal gaan kijken.
        mouseX = Input.GetAxis("Mouse X");
        mouseY = -Input.GetAxis("Mouse Y");
        //(Y as draait <>, X as draait v^).
        //Bij cameraRot.x = mouseY; word de verticale beweging die in mouseY was opgeslagen toegewezen naar de x as rotatie van de camera. Vector3 maakt x gelijk aan mouseY (en andersom ook).
        //Bij playerRot.y = mouseX; gebeurt hetzelfde maar word inplaats van de verticale beweging de horizontale beweging toegewezen op de y as van de player.
        //De camera kan nu omhoog en omlaag kijken en de speler links en recht.
        //Als je de x bij de mouseX zet zou je met je muis naar boven moeten bewegen om recht te kijken en naar beneden gaan om links te kijken, daarom zijn deze gedraait.
        cameraRot.x = mouseY;
        playerRot.y = mouseX;
        //met transform.Rotate(playerRot); word het object gedraait in de richtingen die de playerRot bepaald, dit is links en rechts.
        //met cam.transform.Rotate(cameraRot); word het object gedraait in de richtingen die de cameraRot bepaald, dit is omhoog en naar beneden.
        transform.Rotate(playerRot);
        cam.transform.Rotate(cameraRot);
    }
}
