using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void KoopBert()
    {
        Debug.Log("Bert selected");
        buildManager.SetTurretToBuild(buildManager.bert);
    }
    public void KoopEdward()
    {
        Debug.Log("Edward selected");
        buildManager.SetTurretToBuild(buildManager.edward);
    }
    public void KoopEsmee()
    {
        Debug.Log("Esmee selected");
        buildManager.SetTurretToBuild(buildManager.esmee);
    }
    public void KoopBob()
    {
        Debug.Log("Bob selected");
        buildManager.SetTurretToBuild(buildManager.bob);
    }
    public void KoopPaul()
    {
        Debug.Log("Paul selected");
        buildManager.SetTurretToBuild(buildManager.paul);
    }
}
