using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Ruch_3 : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rigidbody;
    public float rotationSpeed = 10f;
    public float speed = 2f;


    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 directionVector = new Vector3(-v, 0, h);
        transform.rotation = Quaternion.Lerp(transfprm.rotation, Quaternion.LookRotation(directionVector), Time.deltatime * 10);

       // animator.SetFloat("Speed", Vector3.ClampMagnitude(directionVector, 1).magnitude;
        rigidbody.velocity = Vector3.ClampMagnitude(directionVector, 1) * speed;
    }
}*/
 