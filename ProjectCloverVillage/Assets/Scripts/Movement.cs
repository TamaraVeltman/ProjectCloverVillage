using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float hor;
    public float vert;
    public Vector3 moveDirection;

    void Start()
    {

    }

    void Update()
    {
        //GetAxis is tussen -1 en 1 en wilt altijd naar 0, Horizontal en Vertical is een vast ding in unity en zo weet hij wat welke doet
        hor = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        //Vector3 pakt de x en z, dat maak je gelijk aan de hor en vert
        moveDirection.x = hor;
        moveDirection.z = vert;
        //je gebruikt transform om bij de translate te komen. Translate weet wat de voorkant is van het object en
        //zorgt ervoor dat het beweegt op de aangegeven richtingen die worden bepaald door de moveDirection
        transform.Translate(moveDirection);
    }
}
