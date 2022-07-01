using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevTools : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerStats.Money += 100;
        }

        if (Input.GetKeyDown(KeyCode.L) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerStats.Lives += 5;
        }

        //if (Input.GetKeyDown(KeyCode.R) && Input.GetKeyDown(KeyCode.LeftShift))
        //{
           
        //}
    }
}
