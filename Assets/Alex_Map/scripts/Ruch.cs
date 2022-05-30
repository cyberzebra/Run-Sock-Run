using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruch : MonoBehaviour
{

    public float speed = 7f;
    public float jumpPower = 200f;
    public bool ground;
    public Rigidbody rb;
   // public CharacterController controller;
    //public Vector3 movement;
    /*public float speed = 2.5f;
    private Vector3 direction;*/

    private void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(ground == true)
            {
                rb.AddForce(transform.up * jumpPower);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            ground = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ground = false;
        }
    }




    /* void Update()
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
     }*/
}
