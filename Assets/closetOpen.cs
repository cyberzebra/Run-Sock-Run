using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class closetOpen : MonoBehaviour
{
    [SerializeField]
    private Canvas Canvas; 
   
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Canvas.enabled = true;
            if (Input.GetMouseButtonDown(KeyCode.E))
            {
                animator.SetBool("Click", true);
            }
        }
        animator.SetBool("isOpen", true);
    }
}
