using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruch : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 movement;
    public float speed = 2.5f;
    private Vector3 direction;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        direction = movement;
        direction.y = 0;

        if (direction.magnitude > 0f)
        {
            transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
        }

        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                movement.y = 5f;
            }
        }
        else { movement.y -= 0.5f; }
    }

    void FixedUpdate()
    {

        controller.Move(movement * Time.fixedDeltaTime * speed);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            fire();
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            notfire();
        }

    }

    void fire()
    {
        speed = 10f;
    }
    void notfire()
    {
        speed = 2.5f;
    }
}
