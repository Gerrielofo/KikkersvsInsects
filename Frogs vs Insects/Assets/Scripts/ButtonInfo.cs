using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int itemID;
    public Text priceTxt;
    
    public GameObject shopManager; 
    
    void Update()
    {
        priceTxt.text = "Price: $" + shopManager.GetComponent<ShopManagerScript>().shopItems[2, itemID].ToString();
    }
}
