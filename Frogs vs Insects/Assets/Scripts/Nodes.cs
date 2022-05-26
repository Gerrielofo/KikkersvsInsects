using UnityEngine;
using UnityEngine.EventSystems;

public class Nodes : MonoBehaviour
{
    public Color hovercolor;
    public Color noPlace;
    public Vector3 positionOffset;

    [Header("Optional")]
    public GameObject turret;

    private Color startcolor;
    private Renderer rend;

    BuildManager buildManager;

    
    void Start()
    {
        rend = GetComponent<Renderer>();
        startcolor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }
    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
        {
            Debug.Log("No frog selected");
            return;
        }
            
        
        if (turret != null)
        {
            Debug.Log("No place");
            return;
        }

        buildManager.BuildTurretOn(this);
        Debug.Log("Deselect");
        buildManager.SelectTurretToBuild(null);
        
    }

    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
            return;

        if (turret != null)
        rend.material.color = noPlace;
        
        rend.material.color = hovercolor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startcolor;
    }
}
