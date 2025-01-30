using UnityEngine;

public class ToggleVisibility : MonoBehaviour {
    [SerializeField] private GameObject toggleObject;

    public void Toggle() {
        if (toggleObject != null) {
            toggleObject.SetActive(!toggleObject.activeSelf);
        }
    }
}
