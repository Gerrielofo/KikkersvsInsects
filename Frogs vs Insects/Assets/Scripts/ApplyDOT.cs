using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyDOT : MonoBehaviour
{
    public static bool doDot = false;
    public float dot = 10f;
    public static float dotDuration = 5f;
    public static bool dotIsOn;


    IEnumerator Dps(Transform enemy)
    {
        EnemyMovement e = enemy.GetComponent<EnemyMovement>();

        dotIsOn = true;
        dotDuration = 5f;
        while (dotDuration > 0)
        {
            e.TakeDamage(dot);
            Debug.Log("Dot");
            yield return new WaitForSeconds(1);
        }
        dotIsOn = false;
        doDot = false;
    }

    void Update()
    {
        if (dotDuration > 0) 
        { 
            dotDuration -= Time.deltaTime;
            if(dotDuration == 5f)
            {
                EnemyMovement e = GetComponent<EnemyMovement>();

                StartCoroutine(Dps(e.transform));
            }         
        }
    }

    public static void DoDps()
    {
        dotDuration = 5f;
    }
}
