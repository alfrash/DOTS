using UnityEngine;
using UnityEngine.InputSystem;

public class MouseWorldPosition : MonoBehaviour
{
    public static MouseWorldPosition Instance { get; private set; }

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    public Vector3 GetPosition() {
        // Create a ray from the camera through the mouse position
        Ray mouseCameraRay = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        // Define a plane at y = 0 (the ground plane)
        Plane plane = new Plane(Vector3.up, Vector3.zero);

        // Perform a raycast to check for intersections with colliders in the scene
        // If the ray hits a collider, return the point of intersection; otherwise, return Vector3.zero
        if (Physics.Raycast(mouseCameraRay, out RaycastHit hitInfo)) {
            return hitInfo.point;
        }else {
            return Vector3.zero;
        }
       
    }

}




