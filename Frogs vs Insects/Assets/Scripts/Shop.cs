using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint bert;
    public TurretBlueprint edward;
    public TurretBlueprint esmee;
    public TurretBlueprint bob;
    public TurretBlueprint paul;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelecteerBert()
    {
        Debug.Log("Bert selected");
        buildManager.SelectTurretToBuild(bert);
    }
    public void SelecteerEdward()
    {
        Debug.Log("Edward selected");
        buildManager.SelectTurretToBuild(edward);
    }
    public void SelecteerEsmee()
    {
        Debug.Log("Esmee selected");
        buildManager.SelectTurretToBuild(esmee);
    }
    public void SelecteerBob()
    {
        Debug.Log("Bob selected");
        buildManager.SelectTurretToBuild(bob);
    }
    public void SelecteerPaul()
    {
        Debug.Log("Paul selected");
        buildManager.SelectTurretToBuild(paul);
    }
}
