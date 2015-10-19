
using UnityEngine;
using Platform = UnityEngine.RuntimePlatform;


public class TouchController : MonoBehaviour {

  static int _touchId = -1;


  static bool isAndroid {
    get { return Application.platform == Platform.Android; }
  }

  static bool isIPhonePlayer {
    get { return Application.platform == Platform.IPhonePlayer; }
  }

  static public bool isSmartDevice {
    get { return isAndroid || isIPhonePlayer; }
  }

  static public bool IsTouchBegan() {
    if (Input.touchCount <= 0) { return false; }

    for (int n = 0; n < Input.touchCount; ++n) {
      if (_touchId == Input.touches[n].fingerId) { return true; }
    }

    if (Input.touches[0].phase == TouchPhase.Began) {
      _touchId = Input.touches[0].fingerId;
      return true;
    }

    return false;
  }

  static public bool IsTouchEnded() {
    if (Input.touchCount <= 0) { return false; }
    return Input.touches[0].phase == TouchPhase.Ended;
  }
}
