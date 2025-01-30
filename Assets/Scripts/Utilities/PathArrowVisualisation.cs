using UnityEngine;
using UnityEngine.AI;

public class PathArrowVisualisation : MonoBehaviour {
    [SerializeField] private NavigationController navigationController;
    [SerializeField] private GameObject arrow;

    private NavMeshPath path;
    private Vector3 nextNavigationPoint = Vector3.zero;

    private void Update() {
        path = navigationController.CalculatedPath;
        SelectNextNavigationPoint();
        arrow.transform.LookAt(nextNavigationPoint);
    }

    private void SelectNextNavigationPoint() {
        if (path.corners.Length > 1) {
            nextNavigationPoint = path.corners[1];
        }
    }
}
