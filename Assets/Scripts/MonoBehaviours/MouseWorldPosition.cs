using UnityEngine;
using UnityEngine.InputSystem;

public class MouseWorldPosition : MonoBehaviour {
    public Vector3 GetPosition() {
        // Create a ray from the camera through the mouse position
        Ray mouseCameraRay = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        // Define a plane at y = 0 (the ground plane)
        Plane plane = new Plane(Vector3.up, Vector3.zero);

        // Check if the ray intersects with the plane and get the intersection point
        if (plane.Raycast(mouseCameraRay, out float distance)) {
            return mouseCameraRay.GetPoint(distance);
        } else {
            return Vector3.zero;
        }
       
    }

    private void Update() {
        Vector3 mouseWorldPos = GetPosition();
        Debug.Log($"Mouse World Position: {mouseWorldPos}");
    }

}




