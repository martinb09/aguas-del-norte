using System;
using UnityEngine;

public class TickSystem : MonoBehaviour {
    public static event Action OnTick;
    [SerializeField] private float tickInterval = 0.5f; // 500 ms per tick
    private float t;

    void Update() {
        t += Time.unscaledDeltaTime;
        if (t >= tickInterval) {
            t = 0f;
            OnTick?.Invoke();
        }
    }
}
