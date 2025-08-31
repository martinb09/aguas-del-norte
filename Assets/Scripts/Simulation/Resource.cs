using System;

public enum ResourceType { Water, Food, Money }

[Serializable]
public class ResourceBank {
    public float Water = 50f;
    public float Food = 20f;
    public float Money = 100f;
}
