using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rcuh_2 : MonoBehaviour
{
   //rivate Animator animator;
    //private Rigidbody rigidbody;
    public CharacterController controller;
    public float speed = 15f;
    public float gravity = -30.81f;
    public float jumpHeight = 3f;
    public Animator anima;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask; 

    Vector3 velocity;
    bool isGrounded;

    void Start()
    {
        anima = GetComponent<Animator>();
       // rigidbody = GetComponent<Rigidbody>();
    }



    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //ector3 directionVector = new Vector3(x, 0, z);
        //nimator.SetFloat("Speed", Vector3.ClampMagnitude(directionVector, 1).magnitude;

        Vector3 move = transform.right * x + transform.forward * z;

        //controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            move.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        move.y += gravity * Time.deltaTime;

        controller.Move(move * Time.deltaTime);

        if (Input.GetButtonDown("w"))
        {
            GetComponent<Animator>().Play("run");
        }

        if (Input.GetButtonUp("w"))
        {
            GetComponent<Animator>().Play("idl");
        }

        if (Input.GetButtonDown("space"))
        {
            GetComponent<Animator>().Play("jump");
        }


        if (Input.GetButtonDown("s"))
        {
            GetComponent<Animator>().Play("run_2");

        }

        if (Input.GetButtonUp("s"))
        {
            GetComponent<Animator>().Play("idl");

        }
    }
}
