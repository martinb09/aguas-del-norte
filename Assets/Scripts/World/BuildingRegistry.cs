using System.Collections.Generic;
using UnityEngine;

public class BuildingRegistry : MonoBehaviour {
    public static BuildingRegistry Instance { get; private set; }
    private List<BuildingInstance> _active = new List<BuildingInstance>();

    void Awake() {
        if (Instance == null) Instance = this;
        else if (Instance != this) Destroy(gameObject);
    }

    public void Register(BuildingInstance b) {
        if (!_active.Contains(b)) _active.Add(b);
    }
    public void Unregister(BuildingInstance b) {
        if (_active.Contains(b)) _active.Remove(b);
    }

    public float TotalWaterDelta() {
        float sum = 0f;
        foreach (var b in _active) {
            if (b.Def != null) sum += b.Def.WaterDeltaPerTick;
        }
        return sum;
    }

    public float TotalMoneyDelta() {
        float sum = 0f;
        foreach (var b in _active) {
            if (b.Def != null) sum += b.Def.MoneyDeltaPerTick;
        }
        return sum;
    }
}
