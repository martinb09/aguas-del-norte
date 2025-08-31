using UnityEngine;
using System.IO;

public class SaveSystem : MonoBehaviour {
    private string saveFile => Path.Combine(Application.persistentDataPath, "save.json");

    public void Save(ResourceBank bank) {
        var json = JsonUtility.ToJson(bank);
        File.WriteAllText(saveFile, json);
        Debug.Log($"Saved to {saveFile}");
    }

    public ResourceBank Load() {
        if (!File.Exists(saveFile)) return new ResourceBank();
        var json = File.ReadAllText(saveFile);
        var bank = JsonUtility.FromJson<ResourceBank>(json);
        Debug.Log($"Loaded from {saveFile}");
        return bank;
    }
}
