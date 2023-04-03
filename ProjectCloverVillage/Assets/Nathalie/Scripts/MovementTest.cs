using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public Vector3 moveDirection;
    public float moveSpeed;

    void Start()
    {

    }

    void Update()
    {
        //GetAxis is tussen -1 en 1 en wilt altijd naar 0, Horizontal en Vertical is een vast ding in unity en zo weet hij wat welke doet.
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        //Vector3 pakt de x en z, dat maak je gelijk aan de hor en vert.
        moveDirection.x = horizontal;
        moveDirection.z = vertical;
        //transform.Translate word gebruikt om een object te verplaatsen, de richtingen hiervan word door moveDirection aangegeven.
        //Met moveSpeed geef je aan hoe snel het object kan bewegen. De waardes hiervan kan je veranderen.
        //Time.deltaTime geeft de tijd aan die is verlopen na de vorige frame, hierdoor kan het object goed en soepel bewegen, ongeacht van wat de framesnelheid van het spel zelf is.
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
