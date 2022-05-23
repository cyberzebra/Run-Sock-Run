using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creaking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] private AudioSource creakSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            creakSound.Play();
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
