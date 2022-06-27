using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyDOT : MonoBehaviour
{

    public static bool doDot = false;
    public float dot = 10f;
    public static float dotDuration = 5f;
    public static bool dotIsOn;
    IEnumerator Dps()
    {
        yield return new WaitForSeconds(1);

        dotIsOn = true;
        while (dotDuration > 0)
        {
            EnemyMovement.health -= dot;
            yield return new WaitForSeconds(1);
        }
        dotIsOn = false;
        doDot = false;
    }

    void Update()
    {
        dotDuration -= Time.deltaTime;
        if(doDot == true && dotIsOn == false)
        StartCoroutine(Dps());
    }
}
