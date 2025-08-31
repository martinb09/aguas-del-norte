using UnityEngine;

public class WaterSystem : MonoBehaviour {
    public ResourceBank Bank = new ResourceBank();

    void OnEnable() => TickSystem.OnTick += Tick;
    void OnDisable() => TickSystem.OnTick -= Tick;

    void Tick() {
        if (BuildingRegistry.Instance == null) return;
        Bank.Water = Mathf.Max(0f, Bank.Water + BuildingRegistry.Instance.TotalWaterDelta());
        Bank.Money = Mathf.Max(0f, Bank.Money + BuildingRegistry.Instance.TotalMoneyDelta());
    }
}
