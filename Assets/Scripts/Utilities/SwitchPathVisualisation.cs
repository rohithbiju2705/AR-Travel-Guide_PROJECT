using UnityEngine;

public class SwitchPathVisualisation : MonoBehaviour {
    [SerializeField] private GameObject lineVisualisation;
    [SerializeField] private GameObject arrowVisualisation;

    private int visualisationMode = 0;

    private void Start() {
        UpdateVisualisation();
    }

    public void ToggleVisualisation() {
        visualisationMode = (visualisationMode + 1) % 3;
        UpdateVisualisation();
    }

    private void UpdateVisualisation() {
        switch (visualisationMode) {
            case 0:
                lineVisualisation.SetActive(true);
                arrowVisualisation.SetActive(false);
                break;
            case 1:
                lineVisualisation.SetActive(false);
                arrowVisualisation.SetActive(true);
                break;
            case 2:
                lineVisualisation.SetActive(false);
                arrowVisualisation.SetActive(false);
                break;
        }
    }
}
