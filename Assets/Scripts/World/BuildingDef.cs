using UnityEngine;

[CreateAssetMenu(menuName = "Defs/Building")]
public class BuildingDef : ScriptableObject {
    public string Id;
    public string DisplayName;
    public GameObject Prefab;
    public int BuildCost = 100;
    public float WaterDeltaPerTick = 0f;
    public float MoneyDeltaPerTick = 0f;
}
