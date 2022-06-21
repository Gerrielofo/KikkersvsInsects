using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeUI : MonoBehaviour
{
    public static GameObject selectUI;
    public GameObject setSelectedUI;
    public static Nodes target;

    private void Start()
    {
        selectUI = setSelectedUI;
    }
    public void SetTarget (Nodes _target)
    {
        target = _target;

        transform.position = target.GetBuildPosition();

        selectUI.SetActive(true);
    }

    public void Hide()
    {
        selectUI.SetActive(false);
    }
}
