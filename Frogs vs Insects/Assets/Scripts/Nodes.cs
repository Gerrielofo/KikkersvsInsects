using UnityEngine;
using UnityEngine.EventSystems;

public class Nodes : MonoBehaviour
{
    public Color hovercolor;
    public Color noPlace;
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
        if(turret == null)
        {
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
            Debug.Log("turret placed");
            
        }
        Debug.Log("Deselect");
        buildManager.SetTurretToBuild(null);
        
    }

    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.GetTurretToBuild() == null)
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
