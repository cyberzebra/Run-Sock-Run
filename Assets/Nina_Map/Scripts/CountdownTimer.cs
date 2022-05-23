using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    float CurrentTime = 0f;
    float startingTime = 60f;

    [SerializeField] TMP_Text CountdownText;

     void Start ()
    {
        CurrentTime = startingTime;
    }

    void Update()
    {
        CurrentTime -= 1 * Time.deltaTime;
        CountdownText.text = CurrentTime.ToString("0");

        if (CurrentTime <= 0)
        {
            CurrentTime = 0;
        }
      
    }
}
