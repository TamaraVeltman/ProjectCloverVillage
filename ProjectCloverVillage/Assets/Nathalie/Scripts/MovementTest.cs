using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public Vector3 moveDirection;
    public float moveSpeed;
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        moveDirection.x = horizontal;
        moveDirection.z = vertical;
        //transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        if (moveDirection.magnitude > 0.1f)
        {
            animator.SetBool("isWalking", true);
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isWalking", false);
            transform.Translate(Vector3.zero);
        }
    }
}
