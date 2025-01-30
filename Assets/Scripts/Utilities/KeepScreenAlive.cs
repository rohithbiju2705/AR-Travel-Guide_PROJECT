using UnityEngine;

public class KeepScreenAlive : MonoBehaviour {
    private void Start() {
        // Prevent screen from turning off while the app is running
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
