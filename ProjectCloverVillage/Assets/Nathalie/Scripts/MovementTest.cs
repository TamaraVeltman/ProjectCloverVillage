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
        //GetAxis ligt tussen -1 en 1, en die wilt altijd terug naar 0, als je naar links of recht beweegt gaat de waarde omhoog tot -1 of 1, wanneer je stopt met bewegen is dit weer 0.
        //Bij horizontal word de toetsinput opgeslagen, dit zijn bijvoorbeeld de links en recht pijltjes op je toetsenbord, bij vertical gebeurt hetzelfde maar dan met de omhoog en omlaag toets.
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        //De Vector3 maakt de x gelijk aan horizontal en de z gelijk aan vertical, zo kan je dus van links naar recht bewegen, en van voor naar achter.
        moveDirection.x = horizontal;
        moveDirection.z = vertical;
        //transform.Translate word gebruikt om een object te verplaatsen, de richtingen hiervan word door moveDirection aangegeven.
        //Met moveSpeed geef je aan hoe snel het object kan bewegen. De waardes hiervan kan je veranderen.
        //Time.deltaTime geeft de tijd aan die is verlopen na de vorige frame, hierdoor kan het object goed en soepel bewegen, ongeacht van wat de framesnelheid van het spel zelf is.
        //moveDirection, moveSpeed en Time.deltaTime moet je allemaal met elkaar vermenigvuldigen, zo bepaal je de afstand die het object kan afleggen per frame.
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
