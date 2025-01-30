using UnityEngine;
using UnityEngine.AI;

public class PathLineVisualisation : MonoBehaviour {
    [SerializeField] private NavigationController navigationController;
    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private float yOffset = 0.1f;

    private void Update() {
        NavMeshPath path = navigationController.CalculatedPath;
        if (path.corners.Length == 0) return;

        Vector3[] adjustedPath = new Vector3[path.corners.Length];
        for (int i = 0; i < path.corners.Length; i++) {
            adjustedPath[i] = new Vector3(path.corners[i].x, path.corners[i].y + yOffset, path.corners[i].z);
        }

        lineRenderer.positionCount = adjustedPath.Length;
        lineRenderer.SetPositions(adjustedPath);
    }
}
