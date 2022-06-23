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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SelecteerBert();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SelecteerBob();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SelecteerEsmee();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SelecteerPaul();
        }
        //if (Input.GetKeyDown(KeyCode.Alpha5))
        //{
        //    SelecteerEdward();
        //}
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
