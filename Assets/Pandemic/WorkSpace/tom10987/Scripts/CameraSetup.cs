
using UnityEngine;


public class CameraSetup : MonoBehaviour {

  void Start() {
    var canvas_ = FindObjectOfType<Canvas>();
    canvas_.worldCamera = Camera.main;
  }
}
