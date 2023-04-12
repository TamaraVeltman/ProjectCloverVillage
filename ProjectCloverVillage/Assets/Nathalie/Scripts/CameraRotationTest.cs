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
        mouseX = Input.GetAxis("Mouse X");
        mouseY = -Input.GetAxis("Mouse Y");
        cameraRot.x = mouseY;
        playerRot.y = mouseX;
        transform.Rotate(playerRot);
        cam.transform.Rotate(cameraRot);
    }
}
