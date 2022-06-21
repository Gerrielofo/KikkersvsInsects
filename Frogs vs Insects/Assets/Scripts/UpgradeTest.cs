using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeTest : MonoBehaviour{
    public void Upgrade()
    {
        PlayerStats.money -= 100;
        NodeUI.selectUI.SetActive(false);
        Nodes.isSelected = false;
        Debug.Log("Upgrade frog");
    }
    public void Sell()
    {
        //GameObject frog = (GameObject)GetComponent<Nodes>().turret;

        PlayerStats.money += 50;
        Destroy(GetComponent<Nodes>().turret);
        Debug.Log("Sell frog");
    }
}
