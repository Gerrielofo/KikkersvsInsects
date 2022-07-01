using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastForwardUI : MonoBehaviour
{
    public GameObject normalSpeed;
    public GameObject fastForwardsSprite;

    private bool isfastforward;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeSprite();
            ChangeSprite2();
        }
    }
    public void ChangeSprite()
    {       
        normalSpeed.SetActive(!normalSpeed.activeSelf);
        isfastforward = !isfastforward;       
    }

    public void ChangeSprite2()
    {
        fastForwardsSprite.SetActive(!fastForwardsSprite.activeSelf);
    }
}
