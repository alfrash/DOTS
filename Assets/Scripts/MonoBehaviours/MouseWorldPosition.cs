using UnityEngine;
using UnityEngine.InputSystem;

public class MouseWorldPosition : MonoBehaviour
{
    public Vector3 GetPosition() {
        // Create a ray from the camera through the mouse position
        Ray mouseCameraRay = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        
        // Perform a raycast to check for intersections with colliders in the scene
        if (Physics.Raycast(mouseCameraRay, out RaycastHit hitInfo)) {
            return hitInfo.point;
        }else {
            return Vector3.zero;
        }
        
    }

    private void Update() {
        Vector3 mouseWorldPos = GetPosition();
        Debug.Log($"Mouse World Position: {mouseWorldPos}");
        
    }
}
