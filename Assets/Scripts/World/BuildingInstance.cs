using UnityEngine;

public class BuildingInstance : MonoBehaviour {
    public BuildingDef Def;

    void OnEnable() {
        if (BuildingRegistry.Instance != null)
            BuildingRegistry.Instance.Register(this);
    }

    void OnDisable() {
        if (BuildingRegistry.Instance != null)
            BuildingRegistry.Instance.Unregister(this);
    }
}
