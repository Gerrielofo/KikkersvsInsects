using UnityEngine;
using UnityEngine.EventSystems;

public class Nodes : MonoBehaviour
{
    public Color hovercolor;
    public Color notEnoughMoney;
    public Vector3 positionOffset;

    public static bool isSelected = false;

    [Header("Optional")]
    public GameObject turret;

    private Color startcolor;
    private Renderer rend;

    BuildManager buildManager;

    
    void Start()
    {
        rend = GetComponent<Renderer>();
        startcolor = rend.material.color;

        positionOffset.y = 0.1f;

        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }
    private void OnMouseDown()
    {
            
        if (turret != null && isSelected == false)
        {
            NodeUI.selectUI.SetActive(true);
            NodeUI.selectUI.transform.position = transform.position;
            isSelected = true;
            return;
        }

        if(isSelected == true)
        {
            NodeUI.selectUI.SetActive(false);
            isSelected = false;
            return;
        }

        if (EventSystem.current.IsPointerOverGameObject())
        {
            Debug.Log("Pointer is over a gameobject!");
            return;
        }

        buildManager.BuildTurretOn(this);

        Debug.Log("Deselect");
        
        buildManager.SelectTurretToBuild(null);
        
        if (!buildManager.CanBuild)
        {
            Debug.Log("No frog selected");
            return;
        }
    }

    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
            return;

        if (buildManager.HasMoney)
        {
            rend.material.color = hovercolor;
        }
        else
        {
            rend.material.color = Color.red;
        }
    }

    private void OnMouseExit()
    {
        rend.material.color = startcolor;
    }
}
