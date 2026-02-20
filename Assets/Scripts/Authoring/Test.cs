using UnityEngine;


public class Test : MonoBehaviour {

    private int value = 60;
    private int value2 = 65;
    private void Awake() {
        print("Awake");
    }
    private void Start() {
        print("Start");
    }
    private void Update() {
        if (value2 == 65) {
            print("Update");
            value2 = 70;
        }
    }
    private void FixedUpdate() {
        if (value == 60) {
            print("Fixed Update");
            value = 65;
        }
    }
    private void OnEnable() {
        print("OnEnable");
    }
    private void OnDisable() {
        print("OnDisable");
    }
    private void OnDestroy() {
        print("OnDestroy");
    }
    
}
