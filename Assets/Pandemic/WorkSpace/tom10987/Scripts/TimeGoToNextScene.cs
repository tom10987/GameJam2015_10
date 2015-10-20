
using UnityEngine;
using UnityEngine.UI;


public class TimeGoToNextScene : MonoBehaviour {

  [SerializeField]
  string _nextScene = null;

  [SerializeField]
  float _waitTime = 2.0f;
  float _elapsedTime = 0.0f;

  Image _hideFilter = null;
  float _alpha = 0.0f;


  void Start() {
    _hideFilter = GameObject.Find("Filter").GetComponent<Image>();
  }

  void Update() {
    if (IsWaitScene()) { return; }

    _hideFilter.color = new Color(0f, 0f, 0f, _alpha);
    _alpha += Time.deltaTime * 0.5f;

    if (_alpha < 1.0f) { return; }

    Application.LoadLevel(_nextScene);
  }

  // シーンが変わるまで少し待機
  bool IsWaitScene() {
    _elapsedTime += Time.deltaTime;
    return _elapsedTime < _waitTime;
  }
}
