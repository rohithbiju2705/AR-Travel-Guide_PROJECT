using TMPro;
using UnityEngine;

public class SetUiText : MonoBehaviour {
    [SerializeField] private TMP_Text textField;
    [SerializeField] private string prefix;

    public void OnSliderValueChanged(float value) {
        textField.text = $"{prefix}: {value:F2}";
    }
}
