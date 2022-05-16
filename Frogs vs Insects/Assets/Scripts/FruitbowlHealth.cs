using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitbowlHealth : MonoBehaviour
{
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 150;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Insect")
        {
            print("kut collision");
            health -= 5;
        }
    }
}
