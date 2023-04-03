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
        //Je gebruikt transform om bij de translate te komen. Translate weet wat de voorkant van het object is.
        //moveDirection geeft richtingen aan waarop het object moet bewegen.
        //moveSpeed is de snelheid van het object.
        //Time.deltaTime is
        //moveDirection moet je vermenigvuldigen met moveSpeed en Time.deltaTime. Door dit te doen weet het object welke richting het op moet bewegen met welke snelheid.
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
