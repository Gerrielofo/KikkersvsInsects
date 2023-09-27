using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevTools : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            PlayerStats.Money += 100000;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerStats.Lives += 5;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerStats.Lives = 1;
        }
        
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            PlayerStats.Lives = 0;
        }
    }
}
