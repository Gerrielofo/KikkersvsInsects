using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastForwardUI : MonoBehaviour
{
    public GameObject normalSpeed;

    private bool isfastforward;
    

    public void ChangeSprite()
    {       
        normalSpeed.SetActive(!normalSpeed.activeSelf);
        isfastforward = !isfastforward;       
    }
}
