using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;

public class door6Open_dotween : MonoBehaviour
{
    // Start is called before the first frame update
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
