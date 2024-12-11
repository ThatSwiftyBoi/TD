using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    void Awake ()
    {
        if (instance != null)
        {
            Debug.LogError("More then one Build in scene");
            return;
        }
        instance = this;
    }
    
    

    public GameObject standardTurretPrefab;
    public GameObject Turret2Prefab;

    

    
    private GameObject turretToBuild;


    public GameObject GetTurretToBuild ()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild (GameObject turret)
    {
        turretToBuild = turret;
    }
    
}
