using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    CharacterController controller;
    Animator animator;

    Vector3 moveDirection = Vector3.zero;

    public float gravity;
    public float speedZ;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            if(Input.GetAxis("Vertical") > 0.0f)
            {
                moveDirection.z = Input.GetAxis("Vertical") * speedZ;
            }
            else
            {
                moveDirection.z = 0;
            }

            transform.Rotate(0, Input.GetAxis("Horizantal") * 3, 0);

            moveDirection.y -= gravity * Time.deltaTime;

            Vector3 globalDirection = transform.TransformDirection(moveDirection);
            controller.Move(g)
        }
    }
}
