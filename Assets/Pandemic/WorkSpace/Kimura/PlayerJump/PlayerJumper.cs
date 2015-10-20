
using UnityEngine;


public class PlayerJumper : MonoBehaviour {

  bool _isJump = false;

  PlayerParameter playerParameter;

  public Vector3 playerPosition { get { return gameObject.transform.position; } }
  Vector3 defaultPos = Vector3.zero;
  
  float _jumpPower = 0f;


  void Start() {
    //playerParameter = GetComponent<PlayerParameter>();
    //_jumpPower = playerParameter.getJumpPower;
    defaultPos = transform.position;
  }

  void Update() {
    if (Input.GetKeyDown(KeyCode.A)) { PlayerJump(); }

    if (transform.position.y > defaultPos.y) {
      _jumpPower -= Time.deltaTime;
      transform.position += Vector3.up * _jumpPower;
    }
    else if (_isJump) {
      _jumpPower = 0f;
      _isJump = false;
    }
  }

  public void PlayerJump() {
    if (!_isJump) {
      _isJump = true;
      _jumpPower = 10f;
    }
  }
}
