using UnityEngine;
using UnityEngine.EventSystems;

public class Nodes : MonoBehaviour
{
    public Color hovercolor;
    public Vector3 positionOffset;

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

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.GetTurretToBuild() == null)
        {
            Debug.Log("No frog selected");
            return;
        }
            
        
        if (turret != null)
        {
            Debug.Log("No place");
            return;
        }

        GameObject turretToBuild = buildManager.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
        GetComponent<BuildManager>().turretToBuild = null;
        return;
        
    }

    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.GetTurretToBuild() == null)
            return;
   
        rend.material.color = hovercolor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startcolor;
    }
}
