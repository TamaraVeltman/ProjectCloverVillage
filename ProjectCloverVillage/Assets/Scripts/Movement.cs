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
        hor = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        moveDirection.x = hor;
        moveDirection.z = vert;
        transform.Translate(moveDirection);
    }
}
