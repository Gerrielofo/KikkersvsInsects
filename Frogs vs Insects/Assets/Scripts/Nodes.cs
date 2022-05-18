using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodes : MonoBehaviour
{
    public Color hovercolor;
    public GameObject turret;
    private Color startcolor;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startcolor = rend.material.color;
    }

    private void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("fuck you");
            return;
        }
    }

    private void OnMouseEnter()
    {
        rend.material.color = hovercolor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startcolor;
    }
}
