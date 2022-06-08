using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class smeeerc : MonoBehaviour
{   
    void OnTriggerEnter(Collider enter)
    {
        if (enter.CompareTag("Player"))
        {
            SceneManager.LoadScene("Przegrana");
        }
    }
}