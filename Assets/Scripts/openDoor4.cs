using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor4 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //tu siê aktywuje tekst 'kliknij e'
            //if (on mouse click E?)
            {
                //animacja
            }
        }
    }
}
