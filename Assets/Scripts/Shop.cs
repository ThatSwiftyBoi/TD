
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    void Start ()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchaseStandardTurret ()
    {
        Debug.Log ("Standart Turret Selected");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }
    
    public void PurchaseTurret2()
    {
        Debug.Log ("Upgraded Turret Selected");
        buildManager.SetTurretToBuild(buildManager.Turret2Prefab);
    }
}
