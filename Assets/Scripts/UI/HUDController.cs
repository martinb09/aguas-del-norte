using UnityEngine;
using TMPro;

public class HUDController : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI waterText;
    [SerializeField] private TextMeshProUGUI moneyText;
    public ResourceBank Bank;

    void Update() {
        if (Bank == null) return;
        if (waterText != null) waterText.text = $"💧 {Bank.Water:0.0}";
        if (moneyText != null) moneyText.text = $"💰 {Bank.Money:0.0}";
    }
}
