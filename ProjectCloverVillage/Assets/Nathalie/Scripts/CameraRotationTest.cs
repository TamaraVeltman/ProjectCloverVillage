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
    // Start is called before the first frame update
    void Start()
    {

    }

    //Main Camera moet op de Player geplaatst zijn
    void Update()
    {
        //GetAxis is tussen -1 en 1 en wilt altijd naar 0, Mouse X en Mouse Y zijn dingen in Unity
        mouseX = Input.GetAxis("Mouse X");
        mouseY = -Input.GetAxis("Mouse Y");
        //Vector3 pakt x en y en maakt die gelijk aan de mouseY en mouseX (Y as draait <>, X as draait v^)
        //als je x op mouseX zet dat moet je naar boven bewegen om rechts te kijken en naar links om naar beneden te kijken
        cameraRot.x = mouseY;
        playerRot.y = mouseX;
        //Rotatie van de Player en Rotatie van de Camera
        //met de transform kan je de rotate aanspreken
        transform.Rotate(playerRot);
        cam.transform.Rotate(cameraRot);
    }
}
