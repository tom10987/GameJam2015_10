
using UnityEngine;


public class TouchGoToNextScene : MonoBehaviour {

  [SerializeField]
  string _nextScene = null;

  void Update() {
    var isTouch = TouchController.IsTouchBegan();
    if (isTouch) { Application.LoadLevel(_nextScene); }
  }
}
