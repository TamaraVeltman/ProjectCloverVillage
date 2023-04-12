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
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        moveDirection.x = horizontal;
        moveDirection.z = vertical;
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
